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
        List<DTOSeat> GetSeats(Guid filmId, DateTime date, string time);
        FilmScreening AddFilmScreening(FilmScreening filmScreening, List<DTOPriceModificationId> priceModificationsIds);
        FilmScreening UpdateFilmScreening(FilmScreening filmScreening, List<DTOPriceModificationId> priceModificationsIds);
        public void RemoveFilmScreenings(Guid filmId, DateTime date);
        void RemoveFilmScreening(Guid filmScreeningId);
    }
}
