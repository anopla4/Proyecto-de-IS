using Cine__backend.Authentication;
using Cine__backend.Models;
using Cine__backend.Models.DTOs;
using System;
using System.Collections.Generic;

namespace Cine__backend.Interfaces
{
    public interface IUserFilmRepository
    {
        public UserFilm GetUserFilm(string userId, Guid filmId);
        public IList<UserFilm> GetUserFilms();
        public DTOFilmStatics GetStaticsForFilm(Guid filmId);
        public IList<DTOFilmStatics> GetFilmsStatics();
        public void AddUserFilm(User user, Film film, int rating);
        public void UpdateUserFilm(string userId, Guid filmId, int rating);
        public void DeleteUserFilm(string userId, Guid filmId);
    }
}
