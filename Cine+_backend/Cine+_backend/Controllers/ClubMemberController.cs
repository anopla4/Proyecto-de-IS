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
    public class ClubMemberController : ControllerBase
    {
        private IClubMemberRepository _clubMemberRep;
        public ClubMemberController(IClubMemberRepository clubMemberRep)
        {
            this._clubMemberRep = clubMemberRep;
        }
        [Authorize(Roles = "WebMaster,Admin")]
        [HttpGet]
        public IActionResult GetClubmembers()
        {
            return Ok(_clubMemberRep.GetClubMembers());
        }
        [Authorize(Roles = "WebMaster,Admin")]
        [HttpGet("{userId}")]
        public IActionResult GetClubMember(string userId)
        {
            try
            {
                var clubMember = _clubMemberRep.GetClubMember(userId);
                return Ok(clubMember);
            }
            catch (Exception e)
            {
                return NotFound(e.Message);
            }
        }
        [Authorize(Roles = "WebMaster,Admin")]
        [HttpPost("{userId}")]
        public IActionResult AddClubMember(string userId, [FromForm]ClubMember clubMember)
        {
            try
            {
                clubMember = _clubMemberRep.AddClubMember(userId, clubMember);
                return Created(HttpContext.Request.Scheme + "://" + HttpContext.Request.Host + HttpContext.Request.Path + "/" + clubMember.UserId, clubMember);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
        [Authorize(Roles = "WebMaster,Admin")]
        [HttpDelete("{userId}")]
        public IActionResult DeleteClubMember(string userId)
        {
            try
            {
                _clubMemberRep.RemoveClubMember(userId);
                return Ok();
            }
            catch (Exception e)
            {
                return NotFound(e.Message);
            }
        }
        [Authorize(Roles = "WebMaster,Admin")]
        [HttpPatch()]
        public IActionResult UpdateClubMember([FromForm]ClubMember clubMember)
        {
            try
            {
                clubMember = _clubMemberRep.UpdateClubMember(clubMember);
                return Ok(clubMember);
            }
            catch (Exception e)
            {
                return NotFound(e.Message);
            }
        }
    }
}
