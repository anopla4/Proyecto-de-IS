using Cine__backend.Interfaces;
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
        public IActionResult AddSeat()
        {
            try
            {
                var seat = _seatRep.AddSeat();
                return Ok(seat);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
        [HttpDelete("{seatId}")]
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
