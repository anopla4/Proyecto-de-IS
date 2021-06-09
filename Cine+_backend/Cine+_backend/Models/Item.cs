using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Cine__backend.Models
{
    public class Item
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public double Price { get; set; }
        //public State? State { get; set; }
    }
    //public enum State
    //{
    //    bought,
    //    canceled
    //}
}
