using Cine__backend.Interfaces;
using Cine__backend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cine__backend.Repositories
{
    public class LevelRepository : ILevelRepository
    {
        private AppDbContext _context;

        public LevelRepository(AppDbContext context)
        {
            this._context = context;
        }
        public Level AddLevel(Level level)
        {
            level.Id = Guid.NewGuid();
            _context.Levels.Add(level);
            _context.SaveChanges();
            return level;
        }

        public void DeleteLevel(Level level)
        {
            var oldLevel = _context.Levels.Find(level.Id);
            if (oldLevel is null)
            {
                throw new KeyNotFoundException($"No se encuentra el Nivel especificado con id:{level.Id}.");
            }
            _context.Levels.Remove(oldLevel);
            _context.SaveChanges();
        }

        public Level GetLevel(Guid id)
        {
            var level = _context.Levels.Find(id);
            if (level is null)
            {
                throw new KeyNotFoundException($"No se encuentra el Nivel especificado con id:{id}.");
            }
            return level;
        }

        public List<Level> GetLevels()
        {
            return _context.Levels.ToList();
        }

        public Level UpdateLevel(Level level)
        {
            var oldLevel = _context.Levels.Find(level.Id);
            if (oldLevel is null)
            {
                throw new KeyNotFoundException($"No se encuentra la Sala especificada con id:{level.Id}.");
            }
            oldLevel.Name = level.Name;
            _context.Levels.Update(oldLevel);
            _context.SaveChanges();
            return oldLevel;
        }
    }
}
