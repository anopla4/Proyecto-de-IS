using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Cine__backend.Models
{
    public class BookEntry
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public double Income { get; set; }
        [Required]
        public double Expense { get; set; }
        [Required]
        [Column(TypeName = "date")]
        public DateTime Date { get; set; }
        public string Description { get; set; }
        [Required]
        public PaymentMethod PaymentMethod { get; set; }
    }

    public enum PaymentMethod
    {
        efectivo,
        crédito
    }
}
