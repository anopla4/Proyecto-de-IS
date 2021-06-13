using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Cine__backend.Models
{
    public class Item
    {
        [Key]
        public Guid Id { get; set; }
        [Range(0, 10000, ErrorMessage = "El rango válido es 0-10000")]
        public double? Price { get; set; }
        [Range(0, 1000000, ErrorMessage = "El rango válido es 0-1000000")]
        public int? Points { get; set; }
    }

}
