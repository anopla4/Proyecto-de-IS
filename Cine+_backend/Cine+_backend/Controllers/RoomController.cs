using Cine__backend.Models;
using Cine__backend.Repositories;
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
    public class RoomController : ControllerBase
    {
        private IRoomRepository _roomRep;
        public RoomController(IRoomRepository roomRepository)
        {
            this._roomRep = roomRepository;
        }
        [HttpGet]
        public IActionResult GetRooms()
        {
            return Ok(_roomRep.GetRooms());
        }
        [HttpGet("{id}")]
        public IActionResult GetRoom(Guid id)
        {
            try
            {
                var room = _roomRep.GetRoom(id);
                return Ok(room);
            }
            catch (Exception e)
            {
                return NotFound(e.Message);
            }
        }
        [HttpPost]
        public IActionResult AddRoom(Room room)
        {
            var newRoom = _roomRep.AddRoom(room);
            if (newRoom == null)
                return BadRequest("No se creó la nueva Sala.");
            return Created(HttpContext.Request.Scheme + "://" + HttpContext.Request.Host + HttpContext.Request.Path + "/" + newRoom.Id, newRoom);
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteRoom(Guid id, Room room)
        {
            try
            {
                _roomRep.DeleteRoom(room);
                return Ok();
            }
            catch (Exception e)
            {
                return NotFound(e.Message);
                throw;
            }
        }
        [HttpPatch("{id}")]
        public IActionResult RoomUpdate(Guid id, Room room)
        {
            try
            {
                var currentRoom = _roomRep.GetRoom(id);
                room.Id = currentRoom.Id;
                _roomRep.UpdateRoom(room);
                return Ok(room);
            }
            catch (Exception e)
            {
                return NotFound(e.Message);
            }
        }

    }
}
