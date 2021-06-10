using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cine__backend.Models.DTOs
{
    public class DTOFilmScreening
    {
        public Guid FilmScreeningId { get; set; }
        public DTOFilm Film { get; set; }
        public Room Room { get; set; }
        public DateTime Date { get; set; }
        public string StartTime { get; set; }
        public List<DTOPriceModification> priceModifications { get; set; }
    }
}
