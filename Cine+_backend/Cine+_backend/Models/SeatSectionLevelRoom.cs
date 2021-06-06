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
        public int SeatId { get; set; }
        public Seat Seat { get; set; }
        [ForeignKey("Section")]
        public Guid SectionId { get; set; }
        public Section Section { get; set; }
        [ForeignKey("Level")]
        public Guid LevelId { get; set; }
        public Level Level { get; set; }
        [ForeignKey("Room")]
        public Guid RoomId { get; set; }
        public Room Room { get; set; }

    }
}
