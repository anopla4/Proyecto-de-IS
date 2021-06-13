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
        [StringLength(4,ErrorMessage = "El año de la pélicula no es válido")]
        public string Year { get; set; }
        [Required]
        [MaxLength(30, ErrorMessage = "El nombre del país ingresado excede el número de caracteres permitidos(30)")]
        public string Country { get; set; }
        [Url(ErrorMessage = "Url no válida")]
        public string ImgPath { get; set; }
        [NotMapped]
        public IFormFile Img { get; set; }


    }
}
