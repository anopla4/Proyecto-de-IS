using Cine__backend.Interfaces;
using Cine__backend.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Cine__backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SeatSectionLevelRoomController : ControllerBase
    {
        private ISeatSectionLevelRoomRepository _seatSectionLevelRoomRep;
        public SeatSectionLevelRoomController(ISeatSectionLevelRoomRepository seatSectionLevelRoomRepository)
        {
            this._seatSectionLevelRoomRep = seatSectionLevelRoomRepository;
        }

        [HttpGet]
        public IActionResult GetAllSeatSectionLevelRooms()
        {
            return Ok(_seatSectionLevelRoomRep.GetAllSeatSectionLevelRoom());
        }

        [HttpGet("{seatId}/{sectionId}/{levelId}/{roomId}")]
        public IActionResult GetSeatSectionLevelRoom(Guid seatId,Guid sectionId,Guid levelId,Guid roomId)
        {
            try
            {
                var seatSeactionLevelRomm = _seatSectionLevelRoomRep.GetSeatSectionLevelRoom(seatId, sectionId, levelId, roomId);
                return Ok(seatSeactionLevelRomm);
            }
            catch (Exception e)
            {
                return NotFound(e.Message);
            }
        }

        [Authorize(Roles = "WebMaster,Admin")]
        [HttpPost]
        public IActionResult AddSeatSectionLevelRoom([FromForm]Guid seatId, [FromForm] Guid sectionId, [FromForm] Guid levelId, [FromForm] Guid roomId)
        {
            try
            {
                _seatSectionLevelRoomRep.AddSeatSectionLevelRoom(seatId, sectionId, levelId, roomId);
                return Ok();
            }
            catch (Exception e)
            {
                var t = e.GetType();
                if (t ==  typeof(InvalidOperationException))
                {
                    return BadRequest(e.Message);
                }
                return NotFound(e.Message);
            }
        }

        [Authorize(Roles = "WebMaster,Admin")]
        [HttpDelete("{seatId}/{sectionId}/{levelId}/{roomId}")]
        public IActionResult RemoveSeatSectionLevelRoom(Guid seatId,Guid sectionId,Guid levelId,Guid roomId)
        {
            try
            {
                _seatSectionLevelRoomRep.RemoveSeatSectionLevelRoom(seatId, sectionId, levelId, roomId);
                return Ok();
            }
            catch (Exception e)
            {
                return NotFound(e.Message);
            }
        }
    }
}
