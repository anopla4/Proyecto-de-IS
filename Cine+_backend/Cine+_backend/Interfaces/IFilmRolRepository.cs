using Cine__backend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cine__backend.Interfaces
{
    public interface IFilmRolRepository
    {
        List<FilmRol> GetRoles();
        FilmRol GetFilmRol(Guid rolId);
        FilmRol AddFilmRol(FilmRol filmRol);
        FilmRol UpdateFilmRol(FilmRol filmRol);
        void RemoveFilmRol(Guid filmRolId);

    }
}
