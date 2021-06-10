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
        [HttpPost]
        public IActionResult AddSeatSeactionLevelRoom([FromForm]Seat seat, [FromForm] Section section, [FromForm] Level level, [FromForm] Room room)
        {
            try
            {
                _seatSectionLevelRoomRep.AddSeatSectionLevelRoom(seat.Id, section.Id, level.Id, room.Id);
                return Ok();
            }
            catch (Exception e)
            {
                var t = e.GetType();
                if (t ==  typeof(InvalidOperationException))
                {
                    return BadRequest(e.Message);
                }
                return BadRequest(e.Message);
            }
        }
        [HttpDelete("{seatId}/{sectionId}/{levelId}/{roomId}")]
        public IActionResult RemoveSeatSeactionLevelRomm(Guid seatId,Guid sectionId,Guid levelId,Guid roomId)
        {
            try
            {
                _seatSectionLevelRoomRep.RemoveSeatSectionLevelRoom(seatId, sectionId, levelId, roomId);
                return Ok();
            }
            catch (Exception e)
            {
                return NotFound(e.Message);
                throw;
            }
        }
    }
}
