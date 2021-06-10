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
    public class ClubMemberController : ControllerBase
    {
        private IClubMemberRepository _clubMemberRep;
        public ClubMemberController(IClubMemberRepository clubMemberRep)
        {
            this._clubMemberRep = clubMemberRep;
        }
        [HttpGet]
        public IActionResult GetClubmembers()
        {
            return Ok(_clubMemberRep.GetClubMembers());
        }
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
        [HttpPatch()]
        public IActionResult UpdateBookEntry([FromForm]ClubMember clubMember)
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
