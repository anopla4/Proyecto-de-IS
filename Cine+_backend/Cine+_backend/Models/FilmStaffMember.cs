using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Cine__backend.Models
{
    public class FilmStaffMember
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Column(TypeName = "date")]
        public DateTime DateOfBirth;
        [Column(TypeName = "date")]
        public DateTime DateOfDeath;

    }
}
