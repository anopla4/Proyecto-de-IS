using Cine__backend.Interfaces;
using Cine__backend.Models;
using Cine__backend.Models.DTOs;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http.Headers;

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
        [HttpGet("staff")]
        public IActionResult GetFilmsWithStaff()
        {
            try
            {
                var films = _filmRep.GetFilmsWithStaff();
                return Ok(films);
            }
            catch(Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpGet("{filmId}")]
        public IActionResult GetFilm(Guid filmId)
        {
            try
            {
                var dtoFilm = _filmRep.GetFilm(filmId);
                return Ok(dtoFilm);
            }
            catch (Exception e)
            {
                return NotFound(e.Message);
            }
        }

        [HttpGet("{filmId}/staff")]
        public IActionResult GetFilmStaff(Guid filmId)
        {
            try
            {
                var staff = _filmRep.GetFilmStaff(filmId);
                return Ok(staff);
            }
            catch(Exception e)
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
        [Authorize(Roles = "WebMaster,Admin")]
        public IActionResult AddFilm([FromForm]Film film,[FromForm]List<Genre> genres,[FromForm]List<DTOMemberRol> membersRol)
        {
            try
            {
                this.SaveFile(film);
                var newDTOFilm = _filmRep.AddFilm(film, genres, membersRol);
                return Created(HttpContext.Request.Scheme + "://" + HttpContext.Request.Host + HttpContext.Request.Path + "/" + newDTOFilm.Film.Id, newDTOFilm);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpDelete("{filmId}")]
        [Authorize(Roles = "WebMaster,Admin")]
        public IActionResult DeleteFilm(Guid filmId)
        {
            try
            {
                _filmRep.DeleteFilm(filmId);
                return Ok();
            }
            catch (Exception e)
            {
                return NotFound(e.Message);
                throw;
            }
        }

        [HttpPatch("{filmId}")]
        [Authorize(Roles = "WebMaster,Admin")]
        public IActionResult UpdateFilm(Guid filmId,[FromForm]Film film,[FromForm]List<Genre> genres,[FromForm]List<DTOMemberRol> membersRol)
        {
            try
            {
                var currentFilm = _filmRep.GetFilm(filmId).Film;
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
