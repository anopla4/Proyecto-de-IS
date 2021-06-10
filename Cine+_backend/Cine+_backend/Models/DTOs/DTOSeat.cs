using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cine__backend.Models.DTOs
{
    public class DTOSeat
    {
        public Room Room { get; set; }
        public Section Section { get; set; }
        public Level Level { get; set; }
        public Seat Seat { get; set; }
        public bool Available { get; set;}
    }
}
