using Cine__backend.Authentication;
using Microsoft.AspNetCore.Http;
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
        [Required]
        public Guid Code { get; set; }
        [Key]
        [Required]
        [ForeignKey("User")]
        public string UserId { get; set; }
        public User User { get; set; }
        [Required]
        public string Name { get; set; }
        [Column(TypeName = "date")]
        public DateTime? DateOfBirth { get; set; }
        public string Nationality { get; set; }
        public int Points { get; set; }
        [Url(ErrorMessage = "Url no válida")]
        public string ImgPath { get; set; }
        [NotMapped]
        public IFormFile Img { get; set; }

    }
}
