using Cine__backend.Authentication;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cine__backend.Context
{
    public class ApplicationDbContextSeed
    {
        public static async Task SeedEssentialsAsync(UserManager<User> userManager, RoleManager<IdentityRole> roleManager)
        {
            Console.WriteLine("Entra en el seed");
            //Seed Roles
            await roleManager.CreateAsync(new IdentityRole(UserRoles.WebMaster));
            await roleManager.CreateAsync(new IdentityRole(UserRoles.Admin));
            await roleManager.CreateAsync(new IdentityRole(UserRoles.Accountant));
            await roleManager.CreateAsync(new IdentityRole(UserRoles.Worker));
            await roleManager.CreateAsync(new IdentityRole(UserRoles.User));
            //Seed Default User
            var defaultUser = new User
            {
                UserName = UserConstants.default_userMasterName,
                Email = UserConstants.default_userMasterEmail,
                EmailConfirmed = true
            };
            if (userManager.Users.All(u => u.Id != defaultUser.Id))
            {
                await userManager.CreateAsync(defaultUser, UserConstants.default_userMasterPassword);
                await userManager.AddToRoleAsync(defaultUser, UserConstants.default_userMasterRol);
            }
        }
    }
}
