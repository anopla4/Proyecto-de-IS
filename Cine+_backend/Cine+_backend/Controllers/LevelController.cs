using Cine__backend.Interfaces;
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
        [HttpGet("{levelId}")]
        public IActionResult GetLevel(Guid levelId)
        {
            try
            {
                var level = _levelRep.GetLevel(levelId);
                return Ok(level);
            }
            catch (Exception e)
            {
                return NotFound(e.Message);
            }
        }
        [Authorize(Roles = "WebMaster,Admin")]
        [HttpPost]
        public IActionResult AddLevel(Level level)
        {
            try
            {
                level = _levelRep.AddLevel(level);
                return Ok(level);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
        [Authorize(Roles = "WebMaster,Admin")]
        [HttpDelete("{levelId}")]
        public IActionResult DeleteLevel(Guid levelId)
        {
            try
            {
                _levelRep.DeleteLevel(levelId);
                return Ok();
            }
            catch (Exception e)
            {
                return NotFound(e.Message);
            }
        }
        [Authorize(Roles = "WebMaster,Admin")]
        [HttpPatch("{levelId}")]
        public IActionResult LevelUpdate(Guid levelId, Level level)
        {
            try
            {
                var currentLevel = _levelRep.GetLevel(levelId);
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
