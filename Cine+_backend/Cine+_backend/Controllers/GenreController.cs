using Cine__backend.Interfaces;
using Cine__backend.Models;
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
    public class GenreController : ControllerBase
    {
        private IGenreRepository _rep;
        public GenreController(IGenreRepository repo)
        {
            _rep = repo;
        }

        [HttpGet]
        public IActionResult GetGenres()
        {
            return Ok(_rep.GetGenres());
        }

        [HttpGet("{genreId}")]
        public IActionResult GetGenre(Guid genreId)
        {
            try
            {
                var genre = _rep.GetGenre(genreId);
                return Ok(genre);
            }
            catch(Exception e)
            {
                return NotFound(e.Message);
            }
        }

        [HttpPost]
        public IActionResult AddGenre(Genre genre)
        {
            try
            {
                genre = _rep.AddGenre(genre);
                return Created(HttpContext.Request.Scheme + "://" + HttpContext.Request.Host + HttpContext.Request.Path + "/" + genre.Id, genre);
            }
            catch(Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPatch("{genreId}")]
        public IActionResult UpdateGenre(Guid genreId, Genre genre)
        {
            try
            {
                genre = _rep.UpdateGenre(genre);
                return Ok(genre);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpDelete("{genreId}")]
        public IActionResult RemoveGenre(Guid genreId)
        {
            try
            {
                _rep.RemoveGenre(genreId);
                return Ok();
            }
            catch (Exception e)
            {
                return NotFound(e.Message);
            }
        }
    }
}
