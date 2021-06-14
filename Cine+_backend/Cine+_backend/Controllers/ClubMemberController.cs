using Cine__backend.Interfaces;
using Cine__backend.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.IO;
using System.Net.Http.Headers;

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

        private void SaveFile(ClubMember clubMember)
        {
            var file = clubMember.Img;
            var folderName = Path.Combine("Resources", "Images");
            var pathToSave = Path.Combine(Directory.GetCurrentDirectory(), folderName);
            if (file.Length > 0)
            {
                var fileName = ContentDispositionHeaderValue.Parse(file.ContentDisposition).FileName.Trim('"');
                var fullPath = Path.Combine(pathToSave, fileName);
                var dbPath = Path.Combine(folderName, fileName);
                using (var stream = new FileStream(fullPath, FileMode.Create))
                {
                    file.CopyTo(stream);
                }
                clubMember.ImgPath = dbPath;
            }
        }

        [HttpPost("{userId}")]
        public IActionResult AddClubMember(string userId, [FromForm]ClubMember clubMember)
        {
            try
            {
                this.SaveFile(clubMember);
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
        [HttpPatch]
        public IActionResult UpdateClubMember([FromForm]ClubMember clubMember)
        {
            try
            {
                var currClubMember = _clubMemberRep.GetClubMember(clubMember.UserId);
                if (currClubMember.ImgPath != null)
                    System.IO.File.Delete(Path.Combine(Directory.GetCurrentDirectory(), currClubMember.ImgPath));
                this.SaveFile(clubMember);
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
