using Cine__backend.Authentication;
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
            };

            var result = await _userManager.CreateAsync(user, model.Password);
            if (result.Succeeded)
            {
                await _userManager.AddToRoleAsync(user, UserRoles.User);
            }
            return new Response
            { Status = Status.Succes, Message = $"Usuario {user.UserName} registrado" };
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
                authenticationModel.Email = user.Email;
                authenticationModel.UserName = user.UserName;
                var rolesList = await _userManager.GetRolesAsync(user).ConfigureAwait(false);
                authenticationModel.Roles = rolesList.ToList();
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


        public async Task<Response> UserAddRoleAsync(UserRoleModel model)
        {
            var user = await _userManager.FindByEmailAsync(model.Email);
            if (user == null)
            {
                return new Response
                { Status = Status.Error, Message = $"Ninguna cuenta con email {model.Email}!" };
            }

            var roleExists = await _roleManager.RoleExistsAsync(model.Role);
            if (roleExists)
            {               
                await _userManager.AddToRoleAsync(user, model.Role);
                return new Response
                { Status = Status.Succes, Message = $"Se asignó el rol {model.Role} al usuario {model.Email}." };
            }
            return new Response
            { Status = Status.Error, Message = $"El rol {model.Role} no existe!" };

        }

        public async Task<Response> UserRemoveRoleAsync(UserRoleModel model)
        {
            var user = await _userManager.FindByEmailAsync(model.Email);
            if (user == null)
            {
                return new Response
                { Status = Status.Error, Message = $"Ninguna cuenta con email {model.Email}!" };
            }

            var roleExists = await _roleManager.RoleExistsAsync(model.Role);
            if (!roleExists)
            {
                return new Response
                { Status = Status.Error, Message = $"El rol {model.Role} no existe!" };
            }
            if(await _userManager.IsInRoleAsync(user, model.Role))
            {
                await _userManager.RemoveFromRoleAsync(user, model.Role);
                return new Response
                { Status = Status.Succes, Message = $"El usuario { model.Email } ya no posse el rol { model.Role }" };
                }
            return new Response
            { Status = Status.Error, Message = $"El usuario {model.Email} no posse el rol {model.Role}" };
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
    
    }
}
