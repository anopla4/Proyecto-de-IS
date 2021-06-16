using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Cine__backend.Models
{
    public class FilmRol
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        [MaxLength(40, ErrorMessage ="El nombre del rol excede el número máximo de caracteres permitidos(20)")]
        public string Name { get; set; }
    }
}
