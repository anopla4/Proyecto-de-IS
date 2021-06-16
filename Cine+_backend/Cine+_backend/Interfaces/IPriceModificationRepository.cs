using Cine__backend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cine__backend.Interfaces
{
    public interface IPriceModificationRepository
    {
        List<PriceModification> GetPriceModifications();
        PriceModification GetPriceModification(Guid priceModificationId);
        PriceModification AddPriceModification(PriceModification priceModification);
        PriceModification UpdatePriceModification(PriceModification priceModification);
        void RemovePriceModification(Guid priceModificationId);
    }
}
