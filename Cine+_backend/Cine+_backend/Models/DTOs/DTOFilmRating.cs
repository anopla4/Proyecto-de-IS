using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cine__backend.Models.DTOs
{
    public class DTOFilmRating
    {
        public Film Film { get; set; }
        public int Raiting { get; set; }
    }
}
