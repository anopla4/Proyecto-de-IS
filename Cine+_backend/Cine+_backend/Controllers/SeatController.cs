using Cine__backend.Interfaces;
using Cine__backend.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Cine__backend.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class SeatController : ControllerBase
    {
        private ISeatRepository _seatRep;
        public SeatController(ISeatRepository seatRepository)
        {
            this._seatRep = seatRepository;
        }

        [HttpGet]
        public IActionResult GetSeats()
        {
            return Ok(_seatRep.GetSeats());
        }

        [HttpGet("{seatId}")]
        public IActionResult GetSeat(Guid seatId)
        {
            try
            {
                var seat = _seatRep.GetSeat(seatId);
                return Ok(seat);
            }
            catch (Exception e)
            {
                return NotFound(e.Message);
            }
        }

        [HttpPost]
        [Authorize(Roles = "WebMaster,Admin")]
        public IActionResult AddSeat(Seat seat)
        {
            try
            {
                seat = _seatRep.AddSeat(seat);
                return Ok(seat);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpDelete("{seatId}")]
        [Authorize(Roles = "WebMaster,Admin")]
        public IActionResult RemoveSeat(Guid seatId)
        {
            try
            {
                _seatRep.RemoveSeat(seatId);
                return Ok();
            }
            catch (Exception e)
            {
                return NotFound(e.Message);
            }
        }
    }
}
