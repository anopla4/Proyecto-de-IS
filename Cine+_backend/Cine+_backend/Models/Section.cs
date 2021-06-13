using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Cine__backend.Models
{
    public class Section
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        [StringLength(30, ErrorMessage = "No puede superar los 30 caracteres")]
        public string Name { get; set; }
    }
}
