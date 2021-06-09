using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cine__backend.Models.DTOs
{
    public class DTOPriceModification
    {
        public PriceModification PriceModification { get; set; }
        public bool Optional { get; set; }
    }
}
