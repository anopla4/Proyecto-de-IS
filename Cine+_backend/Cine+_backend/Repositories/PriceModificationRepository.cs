using Cine__backend.Interfaces;
using Cine__backend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using Cine__backend.Context;

namespace Cine__backend.Repositories
{
    public class PriceModificationRepository : IPriceModificationRepository
    {
        private AppDbContext _context;
        public PriceModificationRepository(AppDbContext context)
        {
            _context = context;
        }
        public PriceModification AddPriceModification(PriceModification priceModification)
        {
            priceModification.Id = Guid.NewGuid();
            _context.PriceModifications.Add(priceModification);
            _context.SaveChanges();
            return priceModification;
        }

        public PriceModification GetPriceModification(Guid priceModificationId)
        {
            var priceModification = _context.PriceModifications.Find(priceModificationId);
            if (priceModification == null)
            {
                throw new KeyNotFoundException("No se encuentra la modificación de precios especificada");
            }
            return priceModification;
        }
        
        public List<PriceModification> GetPriceModifications()
        {
            return _context.PriceModifications.ToList();
        }

        public void RemovePriceModification(Guid priceModificationId)
        {
            var currPriceModification = _context.PriceModifications.Find(priceModificationId);
            if (currPriceModification == null)
            {
                throw new KeyNotFoundException("No se encuentra la modificación de precios especificada");
            }
            _context.PriceModifications.Remove(currPriceModification);
            _context.SaveChanges();
            return;
            
        }

        public PriceModification UpdatePriceModification(PriceModification priceModification)
        {
            var currPriceModification = _context.PriceModifications.Find(priceModification.Id);
            if (currPriceModification == null)
            {
                throw new KeyNotFoundException("No se encuentra la modificación de precios especificada");
            }
            currPriceModification.Name = priceModification.Name;
            currPriceModification.Type = priceModification.Type;
            currPriceModification.Value = priceModification.Value;
            currPriceModification.Description = priceModification.Description;
            _context.PriceModifications.Update(currPriceModification);
            _context.SaveChanges();
            return currPriceModification;
        }
    }
}
