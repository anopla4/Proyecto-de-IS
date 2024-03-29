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
    public class SectionController : ControllerBase
    {
        private ISectionRepository _sectionRep;
        public SectionController(ISectionRepository sectionRepository)
        {
            this._sectionRep = sectionRepository;
        }

        [HttpGet]
        public IActionResult GetSections()
        {
            return Ok(_sectionRep.GetSections());
        }

        [HttpGet("{setionId}")]
        public IActionResult GetSection(Guid sectionId)
        {
            try
            {
                var section = _sectionRep.GetSection(sectionId);
                return Ok(section);
            }
            catch (Exception e)
            {
                return NotFound(e.Message);
            }
        }

        [Authorize(Roles = "WebMaster,Admin")]
        [HttpPost]
        public IActionResult AddSection(Section section)
        {
            try
            {
                section = _sectionRep.AddSection(section);
                return Ok(section);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [Authorize(Roles = "WebMaster,Admin")]
        [HttpDelete("{sectionId}")]
        public IActionResult RemoveSection(Guid sectionId)
        {
            try
            {
                _sectionRep.RemoveSection(sectionId);
                return Ok();
            }
            catch (Exception e)
            {
                return NotFound(e.Message);
                throw;
            }
        }

        [Authorize(Roles = "WebMaster,Admin")]
        [HttpPatch("{sectionId}")]
        public IActionResult UpdateSection(Guid sectionId, Section section)
        {
            try
            {
                var currentSection = _sectionRep.GetSection(sectionId);
                section.Id = currentSection.Id;
                _sectionRep.UpdateSection(section);
                return Ok(section);
            }
            catch (Exception e)
            {
                return NotFound(e.Message);
            }
        }
    }
}
