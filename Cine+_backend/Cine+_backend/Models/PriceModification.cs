using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Cine__backend.Models
{
    public class PriceModification
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        [MaxLength(30, ErrorMessage = "El nombre es demasiado largo, por favor asigne un nombre de menos de 30 caracteres")]
        public string Name { get; set; }
        [Required]
        [Range(0,100,ErrorMessage = "El valor del porciento de modificación no es válido, debe estar entre 0 y 100")]
        public int Value { get; set; }
        [Required]
        [MaxLength(9, ErrorMessage = "No es válido el tipo de descuento")]
        public string Type { get; set; }
        [Required]
        public string Description { get; set; }
    }
}
