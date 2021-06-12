using Cine__backend.Authentication;
using Cine__backend.Interfaces;
using Cine__backend.Models;
using Microsoft.AspNetCore.Authorization;
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
    public class UserFilmController : ControllerBase
    {
        private IUserFilmRepository _userFilmRep;
        public UserFilmController(IUserFilmRepository userFilmRepository)
        {
            this._userFilmRep = userFilmRepository;
        }
        [HttpGet("allUserFilms")]
        public IActionResult GetUserFilms()
        {
            return Ok(_userFilmRep.GetUserFilms());
        }
        [HttpGet("allFilmsRatings")]
        public IActionResult GetFilmsStatics()
        {
            return Ok(_userFilmRep.GetFilmsStatics());
        }
        [HttpGet("{userId}/{filmId}")]
        public IActionResult GetUserFilm(string userId, Guid filmId)
        {
            try
            {
                var userFilm = _userFilmRep.GetUserFilm(userId, filmId);
                return Ok(userFilm);
            }
            catch (Exception e)
            {
                return NotFound(e.Message);
            }
        }
        [HttpGet("{filmId}/rating")]
        public IActionResult GetStaticsForFilm(Guid filmId)
        {
            try
            {
                var filmStatics = _userFilmRep.GetStaticsForFilm(filmId);
                return Ok(filmStatics);
            }
            catch (Exception e)
            {
                return NotFound(e.Message);
            }
        }
        [HttpPost]
        [Authorize(Roles = "WebMaster,Admin,User")]

        public IActionResult AddRating([FromForm] User user, [FromForm] Film film, [FromForm] int rating)
        {
            try
            {
                _userFilmRep.AddUserFilm(user, film, rating);
                return Ok();
            }
            catch (Exception e)
            {
                var t = e.GetType();
                if (t == typeof(ArgumentOutOfRangeException) || t == typeof(InvalidOperationException))
                {
                    return BadRequest(e.Message);
                }
                return BadRequest(e.Message);
            }
        }
        [HttpDelete("{userId}/{filmId}")]
        [Authorize(Roles = "WebMaster,Admin")]

        public IActionResult DeleteUserFilm(string userId, Guid filmId)
        {
            try
            {
                _userFilmRep.DeleteUserFilm(userId, filmId);
                return Ok();
            }
            catch (Exception e)
            {
                return NotFound(e.Message);
                throw;
            }
        }
        [HttpPatch("{userid}/{filmId}")]
        [Authorize(Roles = "WebMaster,Admin,User")]

        public IActionResult UpdateFilm(string userId, Guid filmId, int rating)
        {
            try
            {
                _userFilmRep.UpdateUserFilm(userId, filmId, rating);
                return Ok();
            }
            catch (Exception e)
            {
                if(e.GetType() == typeof(ArgumentOutOfRangeException))
                {
                    return BadRequest(e.Message);
                }
                return NotFound(e.Message);
            }
        }
    }
}
