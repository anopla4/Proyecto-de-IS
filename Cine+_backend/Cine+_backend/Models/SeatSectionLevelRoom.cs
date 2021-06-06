using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Cine__backend.Models
{
    public class SeatSectionLevelRoom
    {
        [ForeignKey("Seat")]
        public Guid SeatId { get; set; }
        public Seat Seat { get; set; }
        [ForeignKey("Section")]
        public Guid SectionId { get; set; }
        public Seat Section { get; set; }
        [ForeignKey("Level")]
        public Guid LevelId { get; set; }
        public Seat Level { get; set; }
        [ForeignKey("Room")]
        public Guid RoomId { get; set; }
        public Seat Room { get; set; }

    }
}
