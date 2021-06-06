using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Cine__backend.Models
{
    public class FilmScreening
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public Room Room { get; set; }
        [Required]
        public Film Film { get; set; }
        [Required]
        [Column(TypeName="date")]
        public DateTime StarTime { get; set; }
    }
}
