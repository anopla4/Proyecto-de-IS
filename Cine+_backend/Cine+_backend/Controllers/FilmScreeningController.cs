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
    public class FilmScreeningController : ControllerBase
    {
        private IFilmScreeningRepository _rep;
        public FilmScreeningController(IFilmScreeningRepository repo)
        {
            _rep = repo;
        }

        [HttpGet]
        public IActionResult GetFilmScreenings()
        {
            return Ok(_rep.GetFilmScreenings());
        }

        [HttpGet("{filmScreeningId}")]
        public IActionResult GetFilmScreening(Guid filmScreeningId)
        {
            try
            {
                var filmScreening = _rep.GetFilmScreening(filmScreeningId);
                return Ok(filmScreening);
            }
            catch(Exception e)
            {
                return NotFound(e.Message);
            }
        }

        [HttpPost]
        public IActionResult AddFilmScreening(FilmScreening filmScreening)
        {
            try
            {
                filmScreening = _rep.AddFilmScreening(filmScreening);
                return Created(HttpContext.Request.Scheme + "://" + HttpContext.Request.Host + HttpContext.Request.Path + "/" + filmScreening.Id, filmScreening);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
        [HttpPatch("{filmScreeningId}")]
        public IActionResult UpdateFilmScreening(Guid filmScreeningId,FilmScreening filmScreening)
        {
            try
            {
                filmScreening = _rep.UpdateFilmScreening(filmScreening);
                return Ok(filmScreening);
            }
            catch (Exception e)
            {
                if (e is FormatException)
                    return BadRequest(e.Message);
                return NotFound(e.Message);
            }
        }

        [HttpDelete("{filmScreeningId}")]
        public IActionResult RemoveFilmScreening(Guid filmScreeningId)
        {
            try
            {
                _rep.RemoveFilmScreening(filmScreeningId);
                return Ok();
            }
            catch (Exception e)
            {
                return NotFound(e.Message);
            }
        }
    }
}
