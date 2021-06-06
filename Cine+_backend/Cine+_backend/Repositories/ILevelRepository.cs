using Cine__backend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cine__backend.Repositories
{
    public interface ILevelRepository
    {
        public List<Level> GetLevels();
        public Level GetLevel(Guid id);
        public Level AddLevel(Level level);
        public Level UpdateLevel(Level level);
        public void DeleteLevel(Level level);
    }
}
