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
