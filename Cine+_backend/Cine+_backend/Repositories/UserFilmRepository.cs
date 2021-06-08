using Cine__backend.Interfaces;
using Cine__backend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cine__backend.Repositories
{
    public class UserFilmRepository : IUserFilmRepository
    {
        public UserFilm AddUserFilm(UserFilm userFilm)
        {
            throw new NotImplementedException();
        }

        public void DeleteUserFilm(Guid userId, Guid filmId)
        {
            throw new NotImplementedException();
        }

        public UserFilm GetUserFilm(Guid userId, Guid filmId)
        {
            throw new NotImplementedException();
        }

        public IList<UserFilm> GetUserFilms()
        {
            throw new NotImplementedException();
        }

        public UserFilm UpdateUserFilm(UserFilm userFilm)
        {
            throw new NotImplementedException();
        }
    }
}
