using Cine__backend.Models;
using Cine__backend.Repositories;
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
    public class LevelController : ControllerBase
    {
        private ILevelRepository _levelRep;
        public LevelController(ILevelRepository levelRepository)
        {
            this._levelRep = levelRepository;
        }
        [HttpGet]
        public IActionResult GetLevels()
        {
            return Ok(_levelRep.GetLevels());
        }
        [HttpGet("{id}")]
        public IActionResult GetLevel(Guid id)
        {
            try
            {
                var level = _levelRep.GetLevel(id);
                return Ok(level);
            }
            catch (Exception e)
            {
                return NotFound(e.Message);
            }
        }
        [HttpPost]
        public IActionResult AddLevel(Level level)
        {
            var newLevel = _levelRep.AddLevel(level);
            if (newLevel == null)
                return BadRequest("No se creó el nuevo Nivel.");
            return Created(HttpContext.Request.Scheme + "://" + HttpContext.Request.Host + HttpContext.Request.Path + "/" + newLevel.Id, newLevel);
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteLevel(Guid id, Level level)
        {
            try
            {
                _levelRep.DeleteLevel(level);
                return Ok();
            }
            catch (Exception e)
            {
                return NotFound(e.Message);
                throw;
            }
        }
        [HttpPatch("{id}")]
        public IActionResult LevelUpdate(Guid id, Level level)
        {
            try
            {
                var currentLevel = _levelRep.GetLevel(id);
                level.Id = currentLevel.Id;
                _levelRep.UpdateLevel(level);
                return Ok(level);
            }
            catch (Exception e)
            {
                return NotFound(e.Message);
            }
        }
    }
}
