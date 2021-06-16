using Cine__backend.Context;
using Cine__backend.Interfaces;
using Cine__backend.Models;
using Cine__backend.Models.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

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

        public void DeleteFilm(Guid filmId)
        {
            var oldFilm = _context.Films.Find(filmId);
            if (oldFilm is null)
            {
                throw new KeyNotFoundException($"No se encuentra el filme especificado con id:{filmId}.");
            }
            _context.Films.Remove(oldFilm);
            _context.SaveChanges();
        }

        public DTOFilm GetFilm(Guid filmId)
        {
            var film = _context.Films.Find(filmId);
            if (film is null)
            {
                throw new KeyNotFoundException($"No se encuentra el filme especificado con id:{filmId}.");
            }
            var filmGenres = _context.FilmGenres.Include(c => c.Genre).
                            Where(c => c.FilmId == filmId).Select(c => c.Genre).ToList();
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

        private bool AllDitinctMembers(List<DTOMemberRol> membersRol, out DTOMemberRol firstDuplicate)
        {
            var checkBuffer = new HashSet<DTOMemberRol>();
            foreach (var m_r in membersRol)
            {
                if (checkBuffer.Add(m_r))
                    continue;
                firstDuplicate = m_r;
                return false;
            }
            firstDuplicate = default(DTOMemberRol);
            return true;
        }
        public DTOFilmStaff UpdateFilm(Film film, List<Genre> genres, List<DTOMemberRol> membersRol)
        {
            var oldFilm = _context.Films.Find(film.Id);
            if (oldFilm is null)
            {
                throw new KeyNotFoundException($"No se encuentra el filme especificado con id:{film.Id}.");
            }
            var first_duplicated = new DTOMemberRol();
            if (!this.AllDitinctMembers(membersRol,out first_duplicated))
            {
                throw new InvalidOperationException($"Se recibió por duplicado el miembro con nombre {first_duplicated.Member} en el rol {first_duplicated.Rol.Name}.");
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

        public List<DTOMemberRol> GetFilmStaff(Guid filmId)
        {
            if(_context.Films.Find(filmId) == null)
            {
                throw new KeyNotFoundException("No se encuentra la película especificada");
            }
            var staff = _context.FilmFilmRols.Include(c => c.FilmRol).Where(c => c.FilmId == filmId).ToList();
            List<DTOMemberRol> members = new List<DTOMemberRol>();
            foreach(var member in staff)
            {
                var dtoMember = new DTOMemberRol { Member = member.MemberRol, Rol = member.FilmRol };
                members.Add(dtoMember);
            }
            return members;
        }

        public List<DTOFilmStaff> GetFilmsWithStaff()
        {
            List<DTOFilmStaff> dTOFilmsStaff = new List<DTOFilmStaff>();
            foreach (var film in _context.Films.ToList())
            {
                var staff = _context.FilmFilmRols.Include(c => c.FilmRol).Where(c => c.FilmId == film.Id).ToList();
                List<DTOMemberRol> staff_ = new List<DTOMemberRol>();
                foreach (var member in staff)
                    staff_.Add(new DTOMemberRol { Member = member.MemberRol, Rol = member.FilmRol });
                var dtoFilmStaff = new DTOFilmStaff
                {
                    Film = film,
                    Genres = _context.FilmGenres.Include(c => c.Genre).
                            Where(c => c.FilmId == film.Id).Select(c => c.Genre).ToList(),
                    Staff = staff_
                };
                dTOFilmsStaff.Add(dtoFilmStaff);
            }
            return dTOFilmsStaff;
        }
    }
}
