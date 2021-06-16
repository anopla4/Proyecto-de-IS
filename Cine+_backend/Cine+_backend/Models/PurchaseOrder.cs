using Cine__backend.Authentication;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Cine__backend.Models
{
    public class PurchaseOrder
    {
        public PurchaseOrder()
        {
            this.PaidByPoints = false;
        }
        [Key]
        public Guid Id { get; set; }
        [Required]
        [ForeignKey("User")]
        public string UserId { get; set; }
        public User User { get; set; }
        [Required]
        public List<Reservation> Items { get; set; }
        [Required]
        public DateTime Date { get; set; }
        [Required]
        public string PurchaseTime { get; set; }
        public StatePurchaseOrder State { get; set; }
        [CreditCard]
        public string CreditCard { get; set; }
        [StringLength(20, ErrorMessage ="No puede superar los 20 caracteres")]
        public string BoxOffice { get; set; }
        public bool PaidByPoints { get; set; }


    }

    public enum StatePurchaseOrder
    {
        pending,
        completed,
        canceled
    }
}
