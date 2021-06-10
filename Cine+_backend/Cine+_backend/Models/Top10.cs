using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Cine__backend.Models
{
    public class Top10Film
    {
        [Key]
        [ForeignKey("Film")]
        public Guid FilmId { get; set; }
        public Film Film { get; set; }
    }
}
