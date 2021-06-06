using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Cine__backend.Models
{
    public class FilmGenre
    {
        [Required]
        [ForeignKey("Film")]
        public Guid FilmId { get; set; }
        public Film Film { get; set; }
        [Required]
        [ForeignKey("Genre")]
        public Guid GenreId { get; set; }
        public Genre Genre { get; set; }
    }
}
