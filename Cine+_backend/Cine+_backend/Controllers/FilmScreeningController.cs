﻿using Cine__backend.Interfaces;
using Cine__backend.Models;
using Cine__backend.Models.DTOs;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

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
                if ( e is KeyNotFoundException)
                    return NotFound(e.Message);
                return BadRequest(e.Message);
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
        [Authorize(Roles = "WebMaster,Admin")]
        [HttpPost]
        public IActionResult AddFilmScreening([FromForm]Guid filmId, [FromForm]DateTime date, [FromForm]List<DTORoomTime> roomTimes, [FromForm] List<DTOPriceModificationId> priceModifications, [FromForm] double price = 20, [FromForm] int points = 20)
        {
            try
            {
                foreach( var roomTime in roomTimes)
                {
                    var filmScreening = new FilmScreening { FilmId = filmId, RoomId = roomTime.Room.Id, Time = roomTime.Time, Date = date, Price = price, Points = points };
                    filmScreening = _rep.AddFilmScreening(filmScreening, priceModifications);
                }
                
                return Ok();
            }
            catch (Exception e)
            {
                if (e is KeyNotFoundException)
                    return NotFound(e.Message);
                return BadRequest(e.Message);
            }
        }
        [Authorize(Roles = "WebMaster,Admin")]
        [HttpPatch("{filmId}/{date}")]
        public IActionResult UpdateFilmScreening(Guid filmId, DateTime date, [FromForm] List<DTORoomTime> roomTimes, [FromForm] List<DTOPriceModificationId> priceModifications, [FromForm] double price = 20, [FromForm] int points = 20)
        {
            try
            {
                _rep.RemoveFilmScreenings(filmId, date);
                foreach (var roomTime in roomTimes)
                {
                    var filmScreening = new FilmScreening { FilmId = filmId, RoomId = roomTime.Room.Id, Time = roomTime.Time, Date = date, Price = price, Points = points };
                    filmScreening = _rep.AddFilmScreening(filmScreening, priceModifications);
                }
                return Ok();
            }
            catch (Exception e)
            {
                if (e is KeyNotFoundException)
                    return NotFound(e.Message);
                return BadRequest(e.Message);
            }
        }
        [Authorize(Roles = "WebMaster,Admin")]
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
