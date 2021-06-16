using System;
using System.Collections.Generic;
using System.Linq;
using Cine__backend.Context;
using Cine__backend.Interfaces;
using Cine__backend.Models;
using Microsoft.EntityFrameworkCore;

namespace Cine__backend.Repositories
{
    public class FilmScreeningPriceModificationRepository : IFilmScreeningPriceModificationRepository
    {
        private AppDbContext _context;
        public FilmScreeningPriceModificationRepository(AppDbContext context)
        {
            _context = context;        
        }
        public void AddFilmScreeningPriceModifications(FilmScreening filmScreening, List<PriceModification> priceModifications)
        {
            if(_context.FilmScreenings.Find(filmScreening.Id) == null)
            {
                throw new KeyNotFoundException("No se encuentra la película especificada");
            }
            foreach(var priceModification in priceModifications)
            {
                if (_context.PriceModifications.Find(priceModification.Id) == null)
                {
                    throw new KeyNotFoundException($"No se encuentra la modificación de precios de nombre {priceModification.Name}");
                }
                _context.FilmScreeningPriceModifications.Add(new FilmScreeningPriceModification { FilmScreeningId = filmScreening.Id, PriceModificationId = priceModification.Id });
            }
            _context.SaveChanges();
            return;
        }

        public void RemoveFilmScreeningPriceModification(Guid filmScreeningId, Guid priceModificationId)
        {
            if(_context.FilmScreenings.Find(filmScreeningId) == null)
            {
                throw new KeyNotFoundException("No se encuentra la película especificada");
            }
            var filmScreeningPriceModification = _context.FilmScreeningPriceModifications.Find(filmScreeningId, priceModificationId);
            if(filmScreeningPriceModification == null)
            {
                throw new KeyNotFoundException("No se encuentra la modificación de precio especificada en esta película");
            }
            _context.FilmScreeningPriceModifications.Remove(filmScreeningPriceModification);
            _context.SaveChanges();
            return;
        }

        public FilmScreeningPriceModification GetFilmScreeningPriceModification(Guid filmScreeningId, Guid priceModificationId)
        {
            var filmScreeningPriceModification = _context.FilmScreeningPriceModifications.Include(c => c.FilmScreening).Include(c => c.PriceModification).SingleOrDefault(c => c.FilmScreeningId == filmScreeningId && c.PriceModificationId ==  priceModificationId);
            if (filmScreeningPriceModification == null)
            {
                if (_context.FilmScreenings.Find(filmScreeningId) == null)
                    throw new KeyNotFoundException("No se encuentra la película especificada");
                throw new KeyNotFoundException("No se encuentra la modificación de precio especificada en esta película");
            }
            return filmScreeningPriceModification;
        }

        public List<FilmScreeningPriceModification> GetFilmScreeningPriceModifications()
        {
            return _context.FilmScreeningPriceModifications.Include(c => c.FilmScreening).Include(c => c.PriceModification).ToList();    
        }

        public List<PriceModification> GetPriceModificationsOfFilmScreening(Guid filmScreeningId)
        {
            if(!_context.FilmScreeningPriceModifications.Any(c => c.FilmScreeningId == filmScreeningId))
            {
                throw new KeyNotFoundException("No se encuentran modificaciones de precio para la puesta en escena especificada");
            }
            return _context.FilmScreeningPriceModifications.Include(c => c.PriceModification).Where(c => c.FilmScreeningId == filmScreeningId).Select(c => c.PriceModification).ToList();
        }

        public void UpdateFilmScreeningPriceModification(FilmScreening filmScreening, List<PriceModification> priceModifications)
        {
            if(!_context.FilmScreenings.Any(c => c.Id == filmScreening.Id))
            {
                throw new KeyNotFoundException("No se encuentra la puesta en escena especificada");
            }
            foreach(var fsPriceMod in _context.FilmScreeningPriceModifications.Where(c => c.FilmScreeningId == filmScreening.Id))
            {
                _context.FilmScreeningPriceModifications.Remove(fsPriceMod);
            }
            foreach (var priceModification in priceModifications)
            {
                if (_context.PriceModifications.Find(priceModification.Id) == null)
                {
                    throw new KeyNotFoundException($"No se encuentra la modificación de precios de nombre {priceModification.Name}");
                }
                _context.FilmScreeningPriceModifications.Add(new FilmScreeningPriceModification { FilmScreeningId = filmScreening.Id, PriceModificationId = priceModification.Id });
            }
            _context.SaveChanges();

        }
    }
}
