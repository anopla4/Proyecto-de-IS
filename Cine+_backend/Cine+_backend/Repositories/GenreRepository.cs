using Cine__backend.Interfaces;
using Cine__backend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cine__backend.Repositories
{
    public class GenreRepository : IGenreRepository
    {
        private AppDbContext _context;
        public GenreRepository(AppDbContext context)
        {
            _context = context;
        }
        public Genre AddGenre(Genre genre)
        {
            genre.Id = Guid.NewGuid();
            _context.Genres.Add(genre);
            _context.SaveChanges();
            return genre;
        }

        public Genre GetGenre(Guid genreId)
        {
            var genre = _context.Genres.Find(genreId);
            if(genre == null)
            {
                throw new KeyNotFoundException("No se encuentra el género especificado");
            }
            return genre;
        }

        public List<Genre> GetGenres()
        {
            return _context.Genres.ToList();
        }

        public void RemoveGenre(Guid genreId)
        {
            var genre = _context.Genres.Find(genreId);
            if (genre == null)
            {
                throw new KeyNotFoundException("No se encuentra el género especificado");
            }
            _context.Genres.Remove(genre);
            _context.SaveChanges();
            return;
        }

        public Genre UpdateGenre(Genre genre)
        {
            var currGenre = _context.Genres.Find(genre.Id);
            if (currGenre == null)
            {
                throw new KeyNotFoundException("No se encuentra el género especificado");
            }
            currGenre.Name = genre.Name;
            _context.Genres.Update(currGenre);
            _context.SaveChanges();
            return currGenre;
        }
    }
}
