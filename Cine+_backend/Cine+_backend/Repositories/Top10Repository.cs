using Cine__backend.Interfaces;
using Cine__backend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using Cine__backend.Context;

namespace Cine__backend.Repositories
{
    public class Top10Repository : ITop10Repository
    {
        private AppDbContext _context;
        public Top10Repository(AppDbContext context)
        {
            _context = context;
        }
        public Top10Film AddTop10Film(Guid filmId)
        {
            var film = _context.Films.Find(filmId);
            if (film == null)
                throw new KeyNotFoundException($"La lista no es válida pues la película con Id = {film.Id} no se encuentra en la Base de datos.");
            var filmTop = new Top10Film { FilmId = film.Id, Film = film };
            _context.Top10.Add(filmTop);
            _context.SaveChanges();
            return filmTop;
        }

        public void RemoveTop10()
        {
            foreach(var film in _context.Top10)
            {
                _context.Top10.Remove(film);
            }
            _context.SaveChanges();
            return;
        }

        public List<Top10Film> GetTop10()
        {
            return _context.Top10.ToList();
        }

        public Top10Film GetTop10Film(Guid filmId)
        {
            var film = _context.Top10.Find(filmId);
            if (film == null)
            {
                throw new KeyNotFoundException("La película especificada no pertenece al Top10");
            }
            return film;
        }

        public void RemoveTop10Film(Guid filmId)
        {
            var film = _context.Top10.Find(filmId);
            if (film == null)
            {
                throw new KeyNotFoundException("La película especificada no pertenece al Top10");
            }
            _context.Top10.Remove(film);
            _context.SaveChanges();
            return;
        }
    }
}
