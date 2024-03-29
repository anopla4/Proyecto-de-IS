﻿using Cine__backend.Interfaces;
using Cine__backend.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Cine__backend.Controllers
{
    [Authorize]
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
        [Authorize(Roles = "WebMaster,Admin")]
        [HttpPost]
        public IActionResult AddFilmRol(FilmRol rol)
        {
            try
            {
                rol = _rep.AddFilmRol(rol);
                return Ok(rol);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
        [Authorize(Roles = "WebMaster,Admin")]
        [HttpPatch("{rolId}")]
        public IActionResult UpdateFilmRol(Guid rolId, FilmRol rol)
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
        [Authorize(Roles = "WebMaster,Admin")]
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
