using Cine__backend.Interfaces;
using Cine__backend.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Cine__backend.Controllers
{
    [Authorize(Roles = "WebMaster,Admin")]
    [Route("api/[controller]")]
    [ApiController]
    public class ReservationController : ControllerBase
    {
        private IReservationRepository _reservationRep;
        public ReservationController(IReservationRepository reservationRepository)
        {
            this._reservationRep = reservationRepository; 
        }

        [HttpGet("{filmScreeningId}")]
        public IActionResult GetReservationsFromFilmScreening(Guid filmScreeningId)
        {
            return Ok(_reservationRep.GetReservationsFromFilmScreening(filmScreeningId));
        }

        [HttpPost]
        public IActionResult AddReservation(Reservation reservation)
        {
            try
            {
                _reservationRep.AddReservation(reservation);
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpDelete("{reservationId}")]
        public IActionResult DeleteReservation(Guid reservationId)
        {
            try
            {
                _reservationRep.RemoveReservation(reservationId);
                return Ok();
            }
            catch (Exception e)
            {
                return NotFound(e.Message);
            }
        }
    }
}
