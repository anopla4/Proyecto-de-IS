using Cine__backend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cine__backend.Interfaces
{
    public interface ITop10Repository
    {
        List<Top10Film> GetTop10();
        Top10Film GetTop10Film(Guid filmId);
        Top10Film AddTop10Film(Guid filmId);
        void RemoveTop10Film(Guid filmId);
    }
}
