using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Cine__backend.Models
{
    public class Level
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        [StringLength(30,ErrorMessage = "No puede sobrepasar los 30 caracteres.")]
        public string Name { get; set; }
        [Required]
        [Range(0, 100, ErrorMessage = "El rango válido es 0-100.")]
        public int PercentOfPriceIncrement { get; set; }
    }
}
