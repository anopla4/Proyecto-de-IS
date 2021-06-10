using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Cine__backend.Models
{
    public class Reservation:Item
    {
        [ForeignKey("FilmScreening")]
        public Guid FilmSreeningId { get; set; }
        public FilmScreening FilmScreening { get; set; }
        [ForeignKey("Seat")]
        public Guid SeatId { get; set; }
        public Seat Seat { get; set; }
    }
}
