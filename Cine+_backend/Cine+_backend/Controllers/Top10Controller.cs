﻿using Cine__backend.Interfaces;
using Cine__backend.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace Cine__backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Top10Controller : ControllerBase
    {
        private ITop10Repository _rep;
        public Top10Controller(ITop10Repository repo)
        {
            _rep = repo;
        }
        [HttpGet]
        public IActionResult GetTop10()
        {
            return Ok(_rep.GetTop10());
        }
        [HttpGet("{filmId}")]
        public IActionResult GetMovieInTop10(Guid filmId)
        {
            try
            {
                var film = _rep.GetTop10Film(filmId);
                return Ok(film);
            }
            catch(Exception e)
            {
                return NotFound(e.Message);
            }
        }
        [HttpPost]
        [Authorize(Roles = "WebMaster,Admin")]

        public IActionResult AddTop10([FromForm] List<Guid> filmsIds)
        {
            try
            {
                foreach (var filmId in filmsIds)
                {
                    _rep.AddTop10Film(filmId);
                }
                return Ok();
            }
            catch(Exception e)
            {
                if (e is KeyNotFoundException)
                    return NotFound(e.Message);
                return BadRequest(e.Message);
            }
        }

        [HttpDelete("{filmId}")]
        [Authorize(Roles = "WebMaster,Admin")]

        public IActionResult RemoveFilmFromTop10(Guid filmId)
        {
            try
            {
                _rep.RemoveTop10Film(filmId);
                return Ok();
            }
            catch(Exception e)
            {
                return NotFound(e.Message);
            }
        }
    }
}
