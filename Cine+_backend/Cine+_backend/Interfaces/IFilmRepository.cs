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
        public DTOFilm GetFilm(Guid filmId);
        public List<DTOFilm> GetFilms();
        public DTOFilmStaff AddFilm(Film film, List<Genre> genres, List<DTOMemberRol> membersRol);
        public DTOFilmStaff UpdateFilm(Film film, List<Genre> genres, List<DTOMemberRol> membersRol);
        public void DeleteFilm(Guid filmId);
    }
}
