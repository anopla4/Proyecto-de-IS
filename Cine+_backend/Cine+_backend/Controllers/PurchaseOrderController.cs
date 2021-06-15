using Cine__backend.Interfaces;
using Cine__backend.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cine__backend.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class PurchaseOrderController : ControllerBase
    {
        private IPurchaseOrderRepository _rep;
        public PurchaseOrderController(IPurchaseOrderRepository repo)
        {
            _rep = repo;
        }

        [HttpGet]
        public IActionResult GetPurchaseOrders()
        {
            return Ok(_rep.GetPurchaseOrders());
        }

        [HttpGet("{orderId}")]
        public IActionResult GetPurchaseOrder(Guid orderId)
        {
            try
            {
                var order = _rep.GetPurchaseOrder(orderId);
                return Ok(order);
            }
            catch(Exception e)
            {
                return NotFound(e.Message);
            }
        }

        [HttpGet("{username}")]
        public IActionResult GetPurchaseOrdersOfUser(string username)
        {
            try
            {
                var purchaseOrders = _rep.GetPurchaseOrdersOfUser(username);
                return Ok(purchaseOrders);
            }
            catch(Exception e)
            {
                return NotFound(e.Message);
            }
        }
        [HttpPatch("{purchaseOrderId}/{creditCard}")]
        public IActionResult PayPurchaseOrder(Guid purchaseOrderId, string creditCard)
        {
            try
            {
                _rep.PayPurchaseOrder(purchaseOrderId, creditCard);
                return Ok();
            }
            catch(Exception e)
            {
                return BadRequest(e.Message);
            }
        }


        [HttpPost]
        public IActionResult AddPurchaseOrder([FromForm] PurchaseOrder purchaseOrder)
        {
            try
            {
                purchaseOrder = _rep.AddPurchaseOrder(purchaseOrder);
                return Created(HttpContext.Request.Scheme + "://" + HttpContext.Request.Host + HttpContext.Request.Path + "/" + purchaseOrder.Id, purchaseOrder);
            }
            catch(Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPatch("{purchaseOrderId}")]
        public IActionResult RemoveItems( Guid purchaseOrderId, [FromForm] List<Guid> itemsIds)
        {
            try
            {

                _rep.RemoveItems(purchaseOrderId, itemsIds);
                return Ok();
            }
            catch (Exception e)
            {
                if (e is KeyNotFoundException)
                    return NotFound(e.Message);
                return BadRequest(e.Message);
            }
        }

        [HttpPatch("{orderId}/check")]
        public IActionResult CheckPendingPurchaseOrder(Guid orderId)
        {
            try
            {
                _rep.CheckPendingToCancel(orderId);
                return Ok();
            }
            catch(Exception e)
            {
                if (e is KeyNotFoundException)
                    return NotFound(e.Message);
                return BadRequest(e.Message);
            }
        }

        [HttpDelete("{orderId}")]
        public IActionResult CancelPurchaseOrder(Guid orderId)
        {
            try
            {
                _rep.CancelPurchaseOrder(orderId);
                return Ok();
                
            }
            catch(Exception e)
            {
                if (e is KeyNotFoundException)
                    return NotFound(e.Message);
                return BadRequest(e.Message);
            }
        }
    }
}
