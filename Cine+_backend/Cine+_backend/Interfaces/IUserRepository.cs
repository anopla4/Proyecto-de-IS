using Cine__backend.Authentication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cine__backend.Interfaces
{
    public interface IUserRepository
    {
        List<User> GetUsers();
        User GetUser(string userId);
        User AddUser();
        void RemoveUser(string userId);
    }
}
