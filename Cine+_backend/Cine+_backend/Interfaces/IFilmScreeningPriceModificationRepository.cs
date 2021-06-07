using Cine__backend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cine__backend.Interfaces
{
    public interface IFilmScreeningPriceModificationRepository
    {
        List<FilmScreeningPriceModification> GetFilmScreeningPriceModifications();
        List<PriceModification> GetPriceModificationsOfFilmScreening(Guid filmScreeningId);
        FilmScreeningPriceModification GetFilmScreeningPriceModification(Guid filmScreeningId, Guid priceModificationId);
        void AddFilmScreeningPriceModifications(FilmScreening filmScreening, List<PriceModification> priceModifications);
        void UpdateFilmScreeningPriceModification(FilmScreening filmScreening, List<PriceModification> priceModifications);
        void RemoveFilmScreeningPriceModification(Guid filmScreening, Guid priceModificationId);
    }
}
