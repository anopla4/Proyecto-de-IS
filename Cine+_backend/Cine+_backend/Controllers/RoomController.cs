﻿using Cine__backend.Interfaces;
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
        [HttpGet("{roomId}")]
        public IActionResult GetRoom(Guid roomId)
        {
            try
            {
                var room = _roomRep.GetRoom(roomId);
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
            try
            {
                room = _roomRep.AddRoom(room);
                return Created(HttpContext.Request.Scheme + "://" + HttpContext.Request.Host + HttpContext.Request.Path + "/" + room.Id, room);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
        [HttpDelete("{roomId}")]
        public IActionResult DeleteRoom(Guid roomId)
        {
            try
            {
                _roomRep.DeleteRoom(roomId);
                return Ok();
            }
            catch (Exception e)
            {
                return NotFound(e.Message);
                throw;
            }
        }
        [HttpPatch("{roomId}")]
        public IActionResult RoomUpdate(Guid roomId, Room room)
        {
            try
            {
                var currentRoom = _roomRep.GetRoom(roomId);
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
