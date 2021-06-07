using Cine__backend.Interfaces;
using Cine__backend.Models;
using Cine__backend.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cine__backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FilmController : ControllerBase
    {
        private IFilmRepository _filmRep;
        public FilmController(IFilmRepository filmRepository)
        {
            this._filmRep = filmRepository;
        }
        [HttpGet]
        public IActionResult GetFilms()
        {
            return Ok(_filmRep.GetFilms());
        }
        [HttpGet("{id}")]
        public IActionResult GetFilm(Guid id)
        {
            try
            {
                var dtoFilm = _filmRep.GetFilm(id);
                return Ok(dtoFilm);
            }
            catch (Exception e)
            {
                return NotFound(e.Message);
            }
        }
        [HttpPost]
        public IActionResult AddFilm(Film film)
        {
            var newDTOFilm = _filmRep.AddFilm(film);
            if (newDTOFilm == null)
                return BadRequest("No se creó el nuevo Nivel.");
            return Created(HttpContext.Request.Scheme + "://" + HttpContext.Request.Host + HttpContext.Request.Path + "/" + newDTOFilm.Film.Id, newDTOFilm);
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteFilm(Guid id, Film film)
        {
            try
            {
                _filmRep.DeleteFilm(film);
                return Ok();
            }
            catch (Exception e)
            {
                return NotFound(e.Message);
                throw;
            }
        }
        [HttpPatch("{id}")]
        public IActionResult FilmUpdate(Guid id, Film film)
        {
            try
            {
                var currentFilm = _filmRep.GetFilm(id).Film;
                film.Id = currentFilm.Id;
                var newDTOFilm = _filmRep.UpdateFilm(film);
                return Ok(newDTOFilm);
            }
            catch (Exception e)
            {
                return NotFound(e.Message);
            }
        }
    }
}
