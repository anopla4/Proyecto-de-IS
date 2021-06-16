using Cine__backend.Authentication;
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
        public void AddUserFilm(string userId, Guid filmId, int rating)
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
            if (userFilm != null)
            {
                if (rating > 5 || rating < 1)
                {
                    throw new ArgumentOutOfRangeException("El valor del rating está fuera del rango válido");
                }
                userFilm.Rating = rating;
                _context.UserFilms.Update(userFilm);
                _context.SaveChanges();
                return;
            }
            if(rating > 5 || rating < 1)
            {
                throw new ArgumentOutOfRangeException("El valor del rating está fuera del rango válido");
            }
            var newUserFilm = new UserFilm { FilmId = filmId, UserId = userId, Rating = rating };
            _context.UserFilms.Add(newUserFilm);
            _context.SaveChanges();
            return;
        }

        public void DeleteUserFilm(string userId, Guid filmId)
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

        public IList<DTOFilmStatics> GetFilmsStatics()
        {
            var films_statics = new List<DTOFilmStatics>();
            foreach(var film in _context.Films)
            {
                var count = 0;
                var rating = 0;
                foreach(var userFilm in _context.UserFilms.Where(c=>c.FilmId == film.Id))
                {
                    count++;
                    rating += userFilm.Rating;
                }
                var films_sreenings = _context.FilmScreenings.Where(f => f.FilmId == film.Id && f.Date < DateTime.Now);
                var timesSeen = 0;
                foreach (var f_s in films_sreenings)
                {
                    timesSeen += _context.Reservations.Where(r => r.FilmScreeningId == f_s.Id).Count();
                }
                films_statics.Add(new DTOFilmStatics {
                    Country = film.Country,
                    Img = film.Img,
                    ImgPath = film.ImgPath,
                    Name = film.Name,
                    Year = film.Year,
                    Rating = (int)(rating / count),
                    TimesSeen = timesSeen,
                });
            }
            return films_statics;
        }

        public List<UserFilm> GetRatingsOfUser(string userId)
        {
            if (_context.Users.SingleOrDefault(c => c.Id == userId) == null)
                throw new KeyNotFoundException("No se encuentra el usuario especificado");
            List<UserFilm> userFilms = _context.UserFilms.Include(c => c.User).Include(c => c.Film).Where(c => c.UserId == userId).ToList();
            return userFilms;
        }

        public DTOFilmStatics GetStaticsForFilm(Guid filmId)
        {
            var film = _context.Films.Find(filmId);
            if (film == null)
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
            var films_sreenings = _context.FilmScreenings.Where(f => f.FilmId == filmId && f.Date < DateTime.Now);
            var timesSeen = 0;
            foreach(var f_s in films_sreenings)
            {
                timesSeen += _context.Reservations.Where(r => r.FilmScreeningId == f_s.Id).Count();
            }
            var dTOFilmStatics = new DTOFilmStatics
            {
                Country = film.Country,
                Img = film.Img,
                ImgPath = film.ImgPath,
                Name = film.Name,
                Year = film.Year,
                Rating = (int)(rating / count),
                TimesSeen = timesSeen,
            };
            return dTOFilmStatics;
        }

        public UserFilm GetUserFilm(string userId, Guid filmId)
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

        public void UpdateUserFilm(string userId, Guid filmId, int rating)
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
