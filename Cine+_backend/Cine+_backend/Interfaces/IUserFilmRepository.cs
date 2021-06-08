using Cine__backend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cine__backend.Interfaces
{
    public interface IUserFilmRepository
    {
        public UserFilm GetUserFilm(Guid userId, Guid filmId);
        public IList<UserFilm> GetUserFilms();
        public UserFilm AddUserFilm(UserFilm userFilm);
        public UserFilm UpdateUserFilm(UserFilm userFilm);
        public void DeleteUserFilm(Guid userId, Guid filmId);
    }
}
