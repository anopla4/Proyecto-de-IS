using Cine__backend.Interfaces;
using Microsoft.AspNetCore.Authorization;
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
    public class UserController : ControllerBase
    {
        private IUserRepository _rep;
        public UserController(IUserRepository repo)
        {
            _rep = repo;
        }

        [HttpGet]
        [Authorize(Roles = "WebMaster,Admin")]

        public IActionResult GetUsers()
        {
            return Ok(_rep.GetUsers());
        }
        [HttpGet("{userId}")]
        public IActionResult GetUser(string userId)
        {
            try
            {
                var user = _rep.GetUser(userId);
                return Ok(user);
            }
            catch(Exception e)
            {
                return NotFound(e.Message);
            }
        }
        [HttpPost]
        [Authorize(Roles = "WebMaster,Admin")]

        public IActionResult AddUser()
        {
            try
            {
                var user = _rep.AddUser();
                return Ok(user);
            }
            catch(Exception e)
            {
                return BadRequest(e.Message);
            }
        }
        [HttpDelete("{userId}")]
        [Authorize(Roles = "WebMaster,Admin")]

        public IActionResult RemoveUser(string userId)
        {
            try
            {
                _rep.RemoveUser(userId);
                return Ok();
            }
            catch(Exception e)
            {
                return NotFound(e.Message);
            }
        }
    }
}
