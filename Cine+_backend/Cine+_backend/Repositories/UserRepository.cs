using Cine__backend.Authentication;
using Cine__backend.Context;
using Cine__backend.Interfaces;
using Cine__backend.Settings;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Cine__backend.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly UserManager<User> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly JWT _jwt;
        private readonly AppDbContext _context;
        public UserRepository(UserManager<User> userManager, RoleManager<IdentityRole> roleManager, IOptions<JWT> jwt, AppDbContext appDbContext)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _jwt = jwt.Value;
            _context = appDbContext;
        }
        public async Task<Response> RegisterAsync(RegisterModel model)
        {
            var userExists = await _userManager.FindByNameAsync(model.Username);
            if (userExists != null)
                return new Response 
                { Status = Status.Error, Message = $"Ya existe un usuario {model.Username}!" };

            var userWithSameEmail = await _userManager.FindByEmailAsync(model.Email);
            if (userWithSameEmail != null)
                return new Response 
                { Status = Status.Error, Message = $"Ya existe un usuario con email {model.Email}!" };
            var user = new User
            {
                UserName = model.Username,
                Email = model.Email,
                EmailConfirmed = true
            };
            var result = await _userManager.CreateAsync(user, model.Password);
            if (result.Succeeded)
            {
                await _userManager.AddToRoleAsync(user, UserRoles.User);
                return new Response
                { Status = Status.Succes, Message = $"Usuario {user.UserName} registrado" };
            }
            return new Response
            { Status = Status.Error, Message = $"El password ingresado no es válido!" +
            $" Debe incluir mayúsculas, minúsculas, números y algún caracter especial." };
        }

        public async Task<AuthenticationModel> LoginAsync(LoginModel model)
        {
            var authenticationModel = new AuthenticationModel();
            var user = await _userManager.FindByEmailAsync(model.Email);
            if (user == null)
            {
                authenticationModel.IsAuthenticated = false;
                authenticationModel.Message = $"Ninguna cuenta registrada con email {model.Email}.";
                return authenticationModel;
            }
            if (await _userManager.CheckPasswordAsync(user, model.Password))
            {
                authenticationModel.IsAuthenticated = true;
                JwtSecurityToken jwtSecurityToken = await CreateJwtToken(user);
                authenticationModel.Token = new JwtSecurityTokenHandler().WriteToken(jwtSecurityToken);
                authenticationModel.Id = user.Id;
                authenticationModel.Email = user.Email;
                authenticationModel.UserName = user.UserName;
                var rolesList = await _userManager.GetRolesAsync(user).ConfigureAwait(false);
                authenticationModel.Roles = rolesList.ToList();
                authenticationModel.ClubMember = await _context.ClubMembers.FindAsync(user.Id) != null;
                return authenticationModel;
            }
            authenticationModel.IsAuthenticated = false;
            authenticationModel.Message = $"Credenciales incorrectas para el usuario {user.Email}.";
            return authenticationModel;
        }
        
        private async Task<JwtSecurityToken> CreateJwtToken(User user)
        {
            var userClaims = await _userManager.GetClaimsAsync(user);
            var roles = await _userManager.GetRolesAsync(user);
            var roleClaims = new List<Claim>();
            for (int i = 0; i < roles.Count; i++)
            {
                roleClaims.Add(new Claim("roles", roles[i]));
            }
            var claims = new[]
            {
                new Claim(JwtRegisteredClaimNames.Sub, user.UserName),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                new Claim(JwtRegisteredClaimNames.Email, user.Email),
                new Claim("uid", user.Id)
            }
            .Union(userClaims)
            .Union(roleClaims);
            var symmetricSecurityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_jwt.Key));
            var signingCredentials = new SigningCredentials(symmetricSecurityKey, SecurityAlgorithms.HmacSha256);
            var jwtSecurityToken = new JwtSecurityToken(
                issuer: _jwt.Issuer,
                audience: _jwt.Audience,
                claims: claims,
                expires: DateTime.UtcNow.AddMinutes(_jwt.DurationInMinutes),
                signingCredentials: signingCredentials);
            return jwtSecurityToken;
        }

        public async Task<IList<UserAccountModel>> GetUsersAsync()
        {
            var all_users = new List<UserAccountModel>();
            var users = _userManager.Users.ToList();
            foreach(var user in users)
            {
                all_users.Add(new UserAccountModel
                {
                    ClubMember = await _context.ClubMembers.FindAsync(user.Id) != null,
                    Email = user.Email,
                    UserName = user.UserName,
                    Roles = await _userManager.GetRolesAsync(user).ConfigureAwait(false)
                });
            }
            return all_users;
        }

        public async Task<UserAccountModel> GetUserByIdAsync(string userId)
        {
            var user = await _userManager.FindByIdAsync(userId);
            if(user == null)
            {
                throw new KeyNotFoundException("No se encuentra el usuario especificado");
            }
            return new UserAccountModel
                    {
                        ClubMember = await _context.ClubMembers.FindAsync(user.Id) != null,
                        Email = user.Email,
                        UserName = user.UserName,
                        Roles = await _userManager.GetRolesAsync(user).ConfigureAwait(false)
                    };
        }
       
        public async Task RemoveUserByIdAsync(string userId)
        {
            var user = await _userManager.FindByIdAsync(userId);
            if (user == null)
            {
                throw new KeyNotFoundException("No se encuentra el usuario especificado");
            }
            await _userManager.DeleteAsync(user);
            return;
        }

        public async Task<IList<UserAccountModel>> UpdateUsersRoles(IList<UserRolesModel> usersRolesModels)
        {
            foreach (var model in usersRolesModels)
            {
                if (await _userManager.FindByEmailAsync(model.Email) == null)
                    throw new KeyNotFoundException($"No se encuentra el usuario {model.Email}");
                foreach (var role in model.Roles)
                    if (!await _roleManager.RoleExistsAsync(role))
                        throw new KeyNotFoundException($"No se encuentra el rol {role}");
            }
            var users_accounts = new List<UserAccountModel>();
            foreach(var model in usersRolesModels)
            {
                var user = await _userManager.FindByEmailAsync(model.Email);
                foreach(var role in await _userManager.GetRolesAsync(user))
                    await _userManager.RemoveFromRoleAsync(user, role);
                foreach(var role in model.Roles)
                    await _userManager.AddToRoleAsync(user, role);
                users_accounts.Add(new UserAccountModel
                {
                    UserName = user.UserName,
                    Email = user.Email,
                    ClubMember = await _context.ClubMembers.FindAsync(user.Id) != null,
                    Roles = model.Roles
                });
            }
            return users_accounts;
        }

        public async Task<Response> AddRoleAsync(string role)
        {
            if(await _roleManager.RoleExistsAsync(role))
            {
                return new Response
                {
                    Status = Status.Error,
                    Message = $"Ya existe el rol {role}"
                };
            }
            await _roleManager.CreateAsync(new IdentityRole(role));
            return new Response
            {
                Status = Status.Succes,
                Message = $"Se creó el rol {role}"
            };
        }
    }
}
