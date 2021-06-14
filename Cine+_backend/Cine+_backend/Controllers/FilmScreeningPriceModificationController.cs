using Cine__backend.Interfaces;
using Cine__backend.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace Cine__backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FilmScreeningPriceModificationController : ControllerBase
    {
        private IFilmScreeningPriceModificationRepository _rep;
        public FilmScreeningPriceModificationController(IFilmScreeningPriceModificationRepository repo)
        {
            _rep = repo;
        }

        [HttpGet]
        public IActionResult GetFilmScreeningPriceModifications()
        {
            return Ok(_rep.GetFilmScreeningPriceModifications());
        }
        
        [HttpGet("{filmScreeningId}")]
        public IActionResult GetPriceModificationOfFilmScreening(Guid filmScreeningId)
        {
            try
            {
                var priceModifications = _rep.GetPriceModificationsOfFilmScreening(filmScreeningId);
                return Ok(priceModifications);
            }
            catch(Exception e)
            {
                return NotFound(e.Message);
            }
        }

        [HttpGet("{filmScreeningId}/{priceModificationId}")]
        public IActionResult GetFilmScreeningPriceModification(Guid filmScreeningId, Guid priceModificationId)
        {
            try
            {
                var fsPriceMod = _rep.GetFilmScreeningPriceModification(filmScreeningId, priceModificationId);
                return Ok(fsPriceMod);
            }
            catch(Exception e)
            {
                return NotFound(e.Message);
            }
        }
        [Authorize(Roles = "WebMaster,Admin")]
        [HttpPost]
        public IActionResult AddFilmScreeningPriceModifications([FromForm]FilmScreening filmScreening, [FromForm] List<PriceModification> priceModifications)
        {
            try
            {
                _rep.AddFilmScreeningPriceModifications(filmScreening, priceModifications);
                return Ok();
            }
            catch(Exception e)
            {
                return NotFound(e.Message);
            }
        }
        [Authorize(Roles = "WebMaster,Admin")]
        [HttpPatch("{filmScreeningId}")]
        public IActionResult UpdateFilmScreeningPriceModifications(Guid filmSreeningId, [FromForm] FilmScreening filmScreening, [FromForm] List<PriceModification> priceModifications)
        {
            try
            {
                _rep.UpdateFilmScreeningPriceModification(filmScreening, priceModifications);
                return Ok();
            }
            catch(Exception e)
            {
                return NotFound(e.Message);
            }
        }
        [Authorize(Roles = "WebMaster,Admin")]
        [HttpDelete("{filmScreeningId}/{priceModificationId}")]
        public IActionResult RemoveFilmScreeningPriceModification(Guid filmScreeningId, Guid priceModificationId)
        {
            try
            {
                _rep.RemoveFilmScreeningPriceModification(filmScreeningId, priceModificationId);
                return Ok();
            }
            catch(Exception e)
            {
                return NotFound(e.Message);
            }
        }
    }
}
