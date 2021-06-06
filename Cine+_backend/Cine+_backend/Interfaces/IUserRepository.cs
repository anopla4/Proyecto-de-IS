using Cine__backend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cine__backend.Interfaces
{
    public interface IUserRepository
    {
        List<User> GetUsers();
        User GetUser(Guid userId);
        User AddUser();
        void RemoveUser(Guid userId);
    }
}
