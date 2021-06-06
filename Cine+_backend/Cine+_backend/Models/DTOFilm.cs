using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cine__backend.Models
{
    public class DTOFilm
    {
        public Film Film { get; set; }
        public IList<Genre> Genres { get; set; }
    }
}
