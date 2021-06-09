using Cine__backend.Interfaces;
using Cine__backend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cine__backend.Repositories
{
    public class FilmRolRepository : IFilmRolRepository
    {
        private AppDbContext _context;
        public FilmRolRepository(AppDbContext context)
        {
            _context = context;
        }
        public FilmRol AddFilmRol(FilmRol filmRol)
        {
            filmRol.Id = Guid.NewGuid();
            _context.Add(filmRol);
            _context.SaveChanges();
            return filmRol;
        }

        public FilmRol GetFilmRol(Guid rolId)
        {
            var rol = _context.FilmRols.Find(rolId);
            if (rol == null)
                throw new KeyNotFoundException("No se encuentra el rol especificado");
            return rol;
        }

        public List<FilmRol> GetRoles()
        {
            return _context.FilmRols.ToList();
        }

        public void RemoveFilmRol(Guid filmRolId)
        {
            var rol = _context.FilmRols.Find(filmRolId);
            if (rol == null)
                throw new KeyNotFoundException("No se encuentra el rol especificado");
            _context.FilmRols.Remove(rol);
            _context.SaveChanges();
            
            return;
        }

        public FilmRol UpdateFilmRol(FilmRol filmRol)
        {
            var rol = _context.FilmRols.Find(filmRol.Id);
            if (rol == null)
                throw new KeyNotFoundException("No se encuentra el rol especificado");
            rol.Name = filmRol.Name;
            _context.FilmRols.Update(rol);
            _context.SaveChanges();

            return rol;
        }
    }

}
