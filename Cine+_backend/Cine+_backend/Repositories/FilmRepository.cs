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
    public class FilmRepository : IFilmRepository
    {
        private AppDbContext _context;

        public FilmRepository(AppDbContext context)
        {
            this._context = context;
        }
        public DTOFilmStaff AddFilm(Film film, List<Genre> genres, List<DTOMemberRol> membersRol)
        {
            film.Id = Guid.NewGuid();
            _context.Films.Add(film);
            foreach (var genre in genres)
                _context.FilmGenres.Add(new FilmGenre() { FilmId = film.Id, GenreId = genre.Id });
            foreach (var member_rol in membersRol)
                _context.FilmFilmRols.Add(new FilmFilmRol() { 
                    FilmId = film.Id, 
                    FilmRolId = member_rol.Rol.Id,
                    MemberRol = member_rol.Member});
            _context.SaveChanges();
            var dtoFilmStaff = new DTOFilmStaff
            {
                Film = film,
                Genres = genres,
                Staff = membersRol
            };
            return dtoFilmStaff;
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

        private Tuple<bool,string> Comparer(List<DTOMemberRol> membersRol)
        {
            HashSet<DTOMemberRol> set_comparer = new HashSet<DTOMemberRol>();
            foreach(var mr in membersRol)
            {
                foreach(var agregado in set_comparer)
                {
                    if(agregado.Member == mr.Member && agregado.Rol.Id == mr.Rol.Id)
                    {
                        return new Tuple<bool, string>(false,
                            $"Se recibió duplicado el miembro {mr.Member}, con rol {mr.Rol.Name}");
                    }
                }
                set_comparer.Add(mr);
            }
            return new Tuple<bool, string>(true, "");
        }
        public DTOFilmStaff UpdateFilm(Film film, List<Genre> genres, List<DTOMemberRol> membersRol)
        {
            var oldFilm = _context.Films.Find(film.Id);
            if (oldFilm is null)
            {
                throw new KeyNotFoundException($"No se encuentra el filme especificado con id:{film.Id}.");
            }
            var comparer = this.Comparer(membersRol);
            if (!comparer.Item1)
            {
                throw new InvalidOperationException(comparer.Item2);
            }
            foreach (var film_genre in _context.FilmGenres.Where(c => c.FilmId == film.Id))
                _context.FilmGenres.Remove(film_genre);
            foreach (var genre in genres)
                _context.FilmGenres.Add(new FilmGenre() { FilmId = film.Id, GenreId = genre.Id });
            foreach (var film_filmRol in _context.FilmFilmRols.Where(c => c.FilmId == film.Id))
                _context.FilmFilmRols.Remove(film_filmRol);
            foreach (var member_rol in membersRol)
                _context.FilmFilmRols.Add(new FilmFilmRol()
                {
                    FilmId = film.Id,
                    FilmRolId = member_rol.Rol.Id,
                    MemberRol = member_rol.Member
                });
            oldFilm.Name = film.Name;
            oldFilm.Country = film.Country;
            oldFilm.Img = film.Img;
            oldFilm.ImgPath = film.ImgPath;
            oldFilm.Year = film.Year;
            _context.Films.Update(oldFilm);
            _context.SaveChanges();
            var dtoFilmStaff = new DTOFilmStaff
            {
                Film = oldFilm,
                Genres = genres,
                Staff = membersRol
            };
            
            return dtoFilmStaff;
        }
    }
}
