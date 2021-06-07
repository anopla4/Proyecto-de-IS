using Cine__backend.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cine__backend.Repositories
{
    public class FilmRepository : IFilmRepository
    {
        private AppDbContext _context;

        public FilmRepository(AppDbContext context)
        {
            this._context = context;
        }
        public DTOFilm AddFilm(Film film)
        {
            film.Id = Guid.NewGuid();
            _context.Films.Add(film);
            var filmGenres = _context.FilmGenres.Include(c => c.Genre).
                            Where(c => c.FilmId == film.Id).Select(c => c.Genre).ToList();
            var dtoFilm = new DTOFilm
            {
                Film = film,
                Genres = filmGenres
            };
            return dtoFilm;
        }

        public void DeleteFilm(Film film)
        {
            var oldFilm = _context.Films.Find(film.Id);
            if (oldFilm is null)
            {
                throw new KeyNotFoundException($"No se encuentra el filme especificado con id:{film.Id}.");
            }
            _context.Films.Remove(oldFilm);
            _context.SaveChanges();
        }

        public DTOFilm GetFilm(Guid id)
        {
            var film = _context.Films.Find(id);
            if (film is null)
            {
                throw new KeyNotFoundException($"No se encuentra el filme especificado con id:{id}.");
            }
            var filmGenres = _context.FilmGenres.Include(c => c.Genre).
                            Where(c => c.FilmId == id).Select(c => c.Genre).ToList();
            var dtoFilm = new DTOFilm
            {
                Film = film,
                Genres = filmGenres
            };
            return dtoFilm;
        }

        public List<DTOFilm> GetFilms()
        {
            List<DTOFilm> dTOFilms = new List<DTOFilm>();
            foreach(var film in _context.Films.ToList())
            {
                var dtoFilm = new DTOFilm
                {
                    Film = film,
                    Genres = _context.FilmGenres.Include(c => c.Genre).
                            Where(c => c.FilmId == film.Id).Select(c => c.Genre).ToList()
                };
                dTOFilms.Add(dtoFilm);
            }
            return dTOFilms;
        }

        public DTOFilm UpdateFilm(Film film)
        {
            var oldFilm = _context.Films.Find(film.Id);
            if (oldFilm is null)
            {
                throw new KeyNotFoundException($"No se encuentra el filme especificado con id:{film.Id}.");
            }
            oldFilm.Name = film.Name;
            oldFilm.Country = film.Country;
            oldFilm.Img = film.Img;
            oldFilm.ImgPath = film.ImgPath;
            oldFilm.Year = film.Year;
            _context.Films.Update(oldFilm);
            _context.SaveChanges();
            var filmGenres = _context.FilmGenres.Include(c => c.Genre).
                            Where(c => c.FilmId == oldFilm.Id).Select(c => c.Genre).ToList();
            var dtoFilm = new DTOFilm
            {
                Film = oldFilm,
                Genres = filmGenres
            };
            return dtoFilm;
        }
    }
}
