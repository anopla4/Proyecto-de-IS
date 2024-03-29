﻿using Cine__backend.Authentication;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Cine__backend.Interfaces
{
    public interface IUserRepository
    {
        Task<Response> RegisterAsync(RegisterModel model);

        Task<AuthenticationModel> LoginAsync(LoginModel model);

        Task<IList<UserAccountModel>> GetUsersAsync();
        
        Task<UserAccountModel> GetUserByIdAsync(string userId);
        
        Task RemoveUserByIdAsync(string userId);

        Task<IList<UserAccountModel>> UpdateUsersRoles(IList<UserRolesModel> usersRolesModels);

        Task<Response> AddRoleAsync(string role);
    }
}
