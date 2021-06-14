﻿using Cine__backend.Interfaces;
using Cine__backend.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Cine__backend.Controllers
{
    [Authorize(Roles = "WebMaster,Admin")]
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
        public IActionResult AddSeat(Seat seat)
        {
            try
            {
                seat = _seatRep.AddSeat(seat);
                return Created(HttpContext.Request.Scheme + "://" + HttpContext.Request.Host + HttpContext.Request.Path + "/" + seat.Id, seat);

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
