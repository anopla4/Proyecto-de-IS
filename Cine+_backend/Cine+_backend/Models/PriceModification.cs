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
        [Range(0,100, ErrorMessage = "El rango válido es 0-100")]
        public int Value { get; set; }
        [Required]
        [MaxLength(9, ErrorMessage = "No es válido el tipo de descuento")]
        public string Type { get; set; }
        [Required]
        [StringLength(140, ErrorMessage = "No puede superar los 140 caracteres")]
        public string Description { get; set; }
    }
}
