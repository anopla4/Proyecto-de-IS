using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Cine__backend.Models
{
    public class FilmScreeningPriceModification
    {
        [Required]
        [ForeignKey("FilmScreening")]
        public Guid FilmScreeningId { get; set; }
        public FilmScreening FilmScreening { get; set; }
        [Required]
        [ForeignKey("PriceModification")]
        public Guid PriceModificationId { get; set; }
        public PriceModification PriceModification { get; set; }
        public bool Optional { get; set; }
    }
}
