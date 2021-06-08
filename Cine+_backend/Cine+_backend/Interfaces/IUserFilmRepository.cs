using Cine__backend.Models;
using Cine__backend.Models.DTOs;
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
        public int GetRatingForFilm(Guid filmId);
        public IList<DTOFilmRating> GetFilmsRetings();
        public UserFilm AddUserFilm(User user, Film film, int rating);
        public UserFilm UpdateUserFilm(UserFilm userFilm);
        public void DeleteUserFilm(Guid userId, Guid filmId);
    }
}
