using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Cine__backend.Models
{
    public class Seat
    {
        [Key]
        public Guid Id { get; set; }
        [StringLength(20, ErrorMessage = "No puede superar los 20 caracteres")]
        public string Code { get; set; }
    }
}
