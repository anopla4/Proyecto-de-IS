using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Cine__backend.Models
{
    public class FilmScreeningPriceModification
    {
        [Required]
        public FilmScreening FilmScreening { get; set; }
        [Required]
        public PriceModification PriceModification { get; set; }
        public bool Optional { get; set; }
    }
}
