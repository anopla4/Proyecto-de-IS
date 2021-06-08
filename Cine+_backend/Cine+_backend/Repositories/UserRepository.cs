using Cine__backend.Interfaces;
using Cine__backend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cine__backend.Repositories
{
    public class UserRepository : IUserRepository
    {
        private AppDbContext _context;
        public UserRepository(AppDbContext context)
        {
            _context = context;
        }   
        public User AddUser()
        {
            User user = new User { Id = Guid.NewGuid() };
            _context.Users.Add(user);
            _context.SaveChanges();
            return user;
        }
        public User GetUser(Guid userId)
        {
            var user = _context.Users.Find(userId);
            if(user == null)
            {
                throw new KeyNotFoundException("No se encuentra el usuario especificado");
            }
            return user;
        }
        public List<User> GetUsers()
        {
            return _context.Users.ToList();
        }
        public void RemoveUser(Guid userId)
        {
            var user = _context.Users.Find(userId);
            if (user == null)
            {
                throw new KeyNotFoundException("No se encuentra el usuario especificado");
            }
            _context.Users.Remove(user);
            _context.SaveChanges();
            return;
        }
    }
}
