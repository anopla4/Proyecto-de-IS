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
        public double? Price { get; set; }
        public int? Points { get; set; }
        //public State? State { get; set; }
    }
    //public enum State
    //{
    //    bought,
    //    canceled
    //}
}
