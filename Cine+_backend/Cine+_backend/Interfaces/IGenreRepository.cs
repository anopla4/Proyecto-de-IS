using Cine__backend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cine__backend.Interfaces
{
    public interface IGenreRepository
    {
        List<Genre> GetGenres();
        Genre GetGenre(Guid genreId);
        Genre AddGenre(Genre genre);
        Genre UpdateGenre(Genre genre);
        void RemoveGenre(Guid genreId);
    }
}
