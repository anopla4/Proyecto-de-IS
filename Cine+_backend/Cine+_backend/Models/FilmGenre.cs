using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Cine__backend.Models
{
    public class FilmGenre
    {
        [Required]
        public Film Film { get; set; }
        [Required]
        public Genre Genre { get; set; }
    }
}
