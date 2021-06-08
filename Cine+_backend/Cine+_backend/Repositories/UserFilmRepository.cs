using Cine__backend.Interfaces;
using Cine__backend.Models;
using Cine__backend.Models.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cine__backend.Repositories
{
    public class UserFilmRepository : IUserFilmRepository
    {
        private AppDbContext _context;
        public UserFilmRepository(AppDbContext context)
        {
            this._context = context;
        }
        public UserFilm AddUserFilm(User user, Film film, int rating)
        {
            if (_context.Users.Find(user.Id) == null)
            {
                throw new KeyNotFoundException("No se encuentra la película especificada");
            }
            if (_context.Films.Find(film.Id) == null)
            {
                throw new KeyNotFoundException("No se encuentra la película especificada");
            }
            if(_context.UserFilms.Find(user.Id, film.Id) != null)
            {
                throw new InvalidOperationException("Ya existe una valoración para esta película por este usuario ");
            }
            if(rating > 5 || rating < 1)
            {
                throw new ArgumentOutOfRangeException("El valor del rating está fuera del rango válido");
            }
            var newUserFilm = new UserFilm { FilmId = film.Id, UserId = user.Id, Rating = rating };
            _context.UserFilms.Add(newUserFilm);
            _context.SaveChanges();
            return newUserFilm;
        }

        public void DeleteUserFilm(Guid userId, Guid filmId)
        {
            throw new NotImplementedException();
        }

        public IList<DTOFilmRating> GetFilmsRetings()
        {
            throw new NotImplementedException();
        }

        public int GetRatingForFilm(Guid filmId)
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
