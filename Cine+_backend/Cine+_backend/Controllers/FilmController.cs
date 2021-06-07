using Cine__backend.Interfaces;
using Cine__backend.Models;
using Cine__backend.Models.DTOs;
using Cine__backend.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
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
        private void SaveFile(Film film)
        {
            var file = film.Img;
            var folderName = Path.Combine("Resources", "Images");
            var pathToSave = Path.Combine(Directory.GetCurrentDirectory(), folderName);
            if (file.Length > 0)
            {
                var fileName = ContentDispositionHeaderValue.Parse(file.ContentDisposition).FileName.Trim('"');
                var fullPath = Path.Combine(pathToSave, fileName);
                var dbPath = Path.Combine(folderName, fileName);
                using (var stream = new FileStream(fullPath, FileMode.Create))
                {
                    file.CopyTo(stream);
                }
                film.ImgPath = dbPath;

            }
        }
        [HttpPost]
        public IActionResult AddFilm([FromForm]Film film,[FromForm]List<Genre> genres,[FromForm]List<DTOMemberRol> membersRol)
        {
            this.SaveFile(film);
            var newDTOFilm = _filmRep.AddFilm(film, genres, membersRol);
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
        public IActionResult UpdateFilm(Guid id,[FromForm]Film film,[FromForm]List<Genre> genres,[FromForm]List<DTOMemberRol> membersRol)
        {
            try
            {
                var currentFilm = _filmRep.GetFilm(id).Film;
                if (currentFilm.ImgPath != null)
                    System.IO.File.Delete(Path.Combine(Directory.GetCurrentDirectory(), currentFilm.ImgPath));
                this.SaveFile(film);
                film.Id = currentFilm.Id;
                var newDTOFilm = _filmRep.UpdateFilm(film, genres, membersRol);
                return Ok(newDTOFilm);
            }
            catch (Exception e)
            {
                return NotFound(e.Message);
            }
        }
    }
}
