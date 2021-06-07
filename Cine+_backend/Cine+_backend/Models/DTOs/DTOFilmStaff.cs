using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cine__backend.Models.DTOs
{
    public class DTOFilmStaff
    {
        public Film Film { get; set; }
        public IList<Genre> Genres { get; set; }
        public IList<DTOMemberRol> Staff { get; set; }
    }
}
