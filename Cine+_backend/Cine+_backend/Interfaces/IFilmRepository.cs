using Cine__backend.Models;
using Cine__backend.Models.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cine__backend.Interfaces
{
    public interface IFilmRepository
    {
        public DTOFilm GetFilm(Guid id);
        public List<DTOFilm> GetFilms();
        public DTOFilm AddFilm(Film film);
        public DTOFilm UpdateFilm(Film film);
        public void DeleteFilm(Film film);
    }
}
