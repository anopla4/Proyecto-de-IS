using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Cine__backend.Models
{
    public class Film
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Year { get; set; }
        //[Required]
        //public Genre Genre { get; set; } Para Film/Genre
        [Required]
        public string Country { get; set; }
        public string ImgPath { get; set; }
        [NotMapped]
        public IFormFile Img { get; set; }


    }
}
