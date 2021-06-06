using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Cine__backend.Models
{
    public class ClubMember
    {
        [Key]
        public Guid Code { get; set; }
        [Required]
        public string Name { get; set; }
        [Column(TypeName = "date")]
        public DateTime? DateOfBirth { get; set; }
        [Column(TypeName = "date")]
        public DateTime? DateOfDeath { get; set; }
        public string Nationality { get; set; }
        public int Points { get; set; }

    }
}
