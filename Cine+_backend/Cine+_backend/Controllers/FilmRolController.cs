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
    public class FilmRolController : ControllerBase
    {
        private IFilmRolRepository _rep;
        public FilmRolController(IFilmRolRepository repo)
        {
            _rep = repo;
        }

        [HttpGet]
        public IActionResult GetFilmRols()
        {
            return Ok(_rep.GetRoles());
        }

        [HttpGet("{rolId}")]
        public IActionResult GetFilmRol(Guid rolId)
        {
            try
            {
                var rol = _rep.GetFilmRol(rolId);
                return Ok(rol);
            }
            catch(Exception e)
            {
                return NotFound(e.Message);
            }
        }

        [HttpPost]
        public IActionResult AddFilmRol(FilmRol rol)
        {
            try
            {
                rol = _rep.AddFilmRol(rol);
                return Created(HttpContext.Request.Scheme + "://" + HttpContext.Request.Host + HttpContext.Request.Path + "/" + rol.Id, rol);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPatch("{rolId}")]
        public IActionResult AddFilmRol(Guid rolId, FilmRol rol)
        {
            try
            {
                rol = _rep.UpdateFilmRol(rol);
                return Ok(rol);
            }
            catch (Exception e)
            {
                return NotFound(e.Message);
            }
        }

        [HttpDelete("{rolId}")]
        public IActionResult RemoveFilmRol(Guid rolId)
        {
            try
            {
                _rep.RemoveFilmRol(rolId);
                return Ok();
            }
            catch (Exception e)
            {
                return NotFound(e.Message);
            }
        }
    }
}
