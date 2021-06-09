using Cine__backend.Models;
using Cine__backend.Models.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cine__backend.Interfaces
{
    public interface IFilmScreeningRepository
    {
        List<DTOFilmScreening> GetFilmScreenings();
        DTOFilmScreening GetFilmScreening(Guid filmScreeningId);
        FilmScreening AddFilmScreening(FilmScreening filmScreening, List<DTOPriceModification> priceModifications);
        FilmScreening UpdateFilmScreening(FilmScreening filmScreening, List<DTOPriceModification> priceModifications);
        void RemoveFilmScreening(Guid filmScreeningId);
    }
}
