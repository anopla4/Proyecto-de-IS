using Cine__backend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cine__backend.Interfaces
{
    public interface IFilmScreeningRepository
    {
        List<FilmScreening> GetFilmScreenings();
        FilmScreening GetFilmScreening(Guid filmScreeningId);
        FilmScreening AddFilmScreening(FilmScreening filmScreening);
        FilmScreening UpdateFilmScreening(FilmScreening filmScreening);
        void RemoveFilmScreening(Guid filmScreeningId);
    }
}
