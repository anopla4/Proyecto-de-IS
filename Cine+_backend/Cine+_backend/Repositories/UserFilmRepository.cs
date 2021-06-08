using Cine__backend.Interfaces;
using Cine__backend.Models;
using Cine__backend.Models.DTOs;
using Microsoft.EntityFrameworkCore;
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
        public void AddUserFilm(User user, Film film, int rating)
        {
            if (_context.Users.Find(user.Id) == null)
            {
                throw new KeyNotFoundException("No se encuentra el usuario especificado");
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
            return;
        }

        public void DeleteUserFilm(Guid userId, Guid filmId)
        {
            if (_context.Users.Find(userId) == null)
            {
                throw new KeyNotFoundException("No se encuentra el usuario especificado");
            }
            if (_context.Films.Find(filmId) == null)
            {
                throw new KeyNotFoundException("No se encuentra la película especificada");
            }
            var userFilm = _context.UserFilms.Find(userId, filmId);
            if (userFilm == null)
            {
                throw new KeyNotFoundException("No existe una valoración del usuario para esta película");
            }
            _context.UserFilms.Remove(userFilm);
            _context.SaveChanges();
            return;
        }

        public IList<DTOFilmRating> GetFilmsRatings()
        {
            var films_ratings = new List<DTOFilmRating>();
            foreach(var film in _context.Films)
            {
                var count = 0;
                var rating = 0;
                foreach(var userFilm in _context.UserFilms.Where(c=>c.FilmId == film.Id))
                {
                    count++;
                    rating += userFilm.Rating;
                }
                films_ratings.Add(new DTOFilmRating { Film = film, Raiting = (int)(rating / count) }) ;
            }
            return films_ratings;
        }

        public int GetRatingForFilm(Guid filmId)
        {
            if (_context.Films.Find(filmId) == null)
            {
                throw new KeyNotFoundException("No se encuentra la película especificada");
            }
            var count = 0;
            var rating = 0;
            foreach (var userFilm in _context.UserFilms.Where(c => c.FilmId == filmId))
            {
                count++;
                rating += userFilm.Rating;
            }
            return (int)(rating / count);
        }

        public UserFilm GetUserFilm(Guid userId, Guid filmId)
        {
            if (_context.Users.Find(userId) == null)
            {
                throw new KeyNotFoundException("No se encuentra el usuario especificado");
            }
            if (_context.Films.Find(filmId) == null)
            {
                throw new KeyNotFoundException("No se encuentra la película especificada");
            }
            var userFilm = _context.UserFilms.Find(userId, filmId);
            if (userFilm == null)
            {
                throw new KeyNotFoundException("No existe una valoración del usuario para esta película");
            }
            return userFilm;
        }

        public IList<UserFilm> GetUserFilms()
        {
            return _context.UserFilms.ToList();
        }

        public void UpdateUserFilm(Guid userId, Guid filmId, int rating)
        {
            if (_context.Users.Find(userId) == null)
            {
                throw new KeyNotFoundException("No se encuentra el usuario especificado");
            }
            if (_context.Films.Find(filmId) == null)
            {
                throw new KeyNotFoundException("No se encuentra la película especificada");
            }
            var oldUserFilm = _context.UserFilms.Find(userId, filmId);
            if (oldUserFilm == null)
            {
                throw new KeyNotFoundException("No existe una valoración para esta película por este usuario ");
            }
            if (rating > 5 || rating < 1)
            {
                throw new ArgumentOutOfRangeException("El valor del rating está fuera del rango válido");
            }
            oldUserFilm.Rating = rating;
            _context.UserFilms.Update(oldUserFilm);
            _context.SaveChanges();
            return;
        }
    }
}
