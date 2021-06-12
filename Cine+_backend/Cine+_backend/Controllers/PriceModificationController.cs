using Cine__backend.Interfaces;
using Cine__backend.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Cine__backend.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class PriceModificationController : ControllerBase
    {
        private IPriceModificationRepository _rep;
        public PriceModificationController(IPriceModificationRepository repo)
        {
            _rep = repo;
        }

        [HttpGet]
        public IActionResult GetPriceModifications()
        {
            return Ok(_rep.GetPriceModifications());
        }

        [HttpGet("{priceModificationId}")]
        public IActionResult GetPriceModification(Guid priceModificationId)
        {
            try
            {
                var priceModification = _rep.GetPriceModification(priceModificationId);
                return Ok(priceModification);
            }
            catch(Exception e)
            {
                return NotFound(e.Message);
            }
        }
        [Authorize(Roles = "WebMaster,Admin")]
        [HttpPost]
        public IActionResult AddPriceModification(PriceModification priceModification)
        {
            try
            {
                priceModification = _rep.AddPriceModification(priceModification);
                return Created(HttpContext.Request.Scheme + "://" + HttpContext.Request.Host + HttpContext.Request.Path + "/" + priceModification.Id, priceModification);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
        [Authorize(Roles = "WebMaster,Admin")]
        [HttpPatch("{priceModificationId}")]
        public IActionResult UpdatePriceModifiation(Guid priceModificationId, PriceModification priceModification)
        {
            try
            {
                priceModification = _rep.UpdatePriceModification(priceModification);
                return Ok(priceModification);
            }
            catch(Exception e)
            {
                return NotFound(e.Message);
            }
        }
        [Authorize(Roles = "WebMaster,Admin")]
        [HttpDelete("{priceModificationId}")]
        public IActionResult RemovePriceModification(Guid priceModificationId, PriceModification priceModification)
        {
            try
            {
                _rep.RemovePriceModifiation(priceModificationId);
                return Ok();
            }
            catch(Exception e)
            {
                return NotFound(e.Message);
            }
        }
    }
}
