using Cine__backend.Interfaces;
using Cine__backend.Models;
using Cine__backend.Models.DTOs;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace Cine__backend.Controllers
{
    [Authorize(Roles = "WebMaster,Admin")]
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

        [HttpGet("{filmId}/{date}/{time}")]
        public IActionResult GetSeats(Guid filmId, DateTime date, string time)
        {
            try
            {
                var seats = _rep.GetSeats(filmId, date, time);
                return Ok(seats);
            }
            catch(Exception e)
            {
                return NotFound(e.Message);
            }
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
        public IActionResult AddFilmScreening([FromForm]Film film, [FromForm]DateTime date, [FromForm]List<DTORoomTime> roomTimes, [FromForm] List<DTOPriceModification> priceModifications)
        {
            try
            {
                foreach( var roomTime in roomTimes)
                {
                    var filmScreening = new FilmScreening { FilmId = film.Id, RoomId = roomTime.Room.Id, Time = roomTime.Time, Date = date };
                    filmScreening = _rep.AddFilmScreening(filmScreening, priceModifications);
                }
                
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
        [HttpPatch("{filmScreeningId}")]
        public IActionResult UpdateFilmScreening( Guid filmScreeningId,[FromForm]FilmScreening filmScreening, [FromForm] List<DTOPriceModification> priceModifications)
        {
            try
            {
                filmScreening = _rep.UpdateFilmScreening(filmScreening, priceModifications);
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
