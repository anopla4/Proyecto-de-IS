using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Cine__backend.Models
{
    public class UserFilm
    {
        [Required]
        public User User { get; set; }
        [Required]
        public Film Film { get; set; }
    }
}
