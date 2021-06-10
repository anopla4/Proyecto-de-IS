﻿using System;
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
        public string Name { get; set; }
        [Required]
        public int PercentOfPriceIncrement { get; set; }
    }
}
