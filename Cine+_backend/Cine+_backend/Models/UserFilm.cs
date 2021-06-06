using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Cine__backend.Models
{
    public class UserFilm
    {
        [Required]
        [ForeignKey("User")]
        public Guid UserId { get; set; }
        public User User { get; set; }
        [Required]
        [ForeignKey("Film")]
        public Guid FilmId { get; set; }
        public Film Film { get; set; }
        [Required]
        public int Rating { get; set; }
    }
}
