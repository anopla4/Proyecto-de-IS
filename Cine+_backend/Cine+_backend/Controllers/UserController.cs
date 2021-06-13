using Cine__backend.Authentication;
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
        private IUserRepository _userRep;
        public UserController(IUserRepository userRepository)
        {
            _userRep = userRepository;
        }

        [HttpPost("register")]
        public async Task<ActionResult> RegisterAsync([FromBody]RegisterModel model)
        {
            var response = await _userRep.RegisterAsync(model);
            if(response.Status == Status.Error)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, response);
            }
            return Ok(response);
        }

        [HttpPost("login")]
        public async Task<IActionResult> LoginAsync(LoginModel model)
        {
            var result = await _userRep.LoginAsync(model);
            return Ok(result);
        }

        [HttpPost("userAddrole")]
        public async Task<IActionResult> UserAddRoleAsync(UserRoleModel model)
        {
            var response = await _userRep.UserRemoveRoleAsync(model);
            if (response.Status == Status.Error)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, response);
            }
            return Ok(response);
        }

        [HttpDelete("userRemoveRole")]
        public async Task<IActionResult> UserRemoveRoleAsync(UserRoleModel model)
        {
            var response = await _userRep.UserRemoveRoleAsync(model);
            if(response.Status == Status.Error)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, response);
            }
            return Ok(response);
        }

        //[HttpGet]
        //[Authorize(Roles = "WebMaster,Admin")]
        //public IActionResult GetUsers()
        //{
        //    return Ok(_rep.GetUsers());
        //}
        //[HttpGet("{userId}")]
        //public IActionResult GetUser(string userId)
        //{
        //    try
        //    {
        //        var user = _rep.GetUser(userId);
        //        return Ok(user);
        //    }
        //    catch(Exception e)
        //    {
        //        return NotFound(e.Message);
        //    }
        //}
        //[HttpPost]
        //[Authorize(Roles = "WebMaster,Admin")]

        //public IActionResult AddUser()
        //{
        //    try
        //    {
        //        var user = _rep.AddUser();
        //        return Ok(user);
        //    }
        //    catch(Exception e)
        //    {
        //        return BadRequest(e.Message);
        //    }
        //}
        //[HttpDelete("{userId}")]
        //[Authorize(Roles = "WebMaster,Admin")]

        //public IActionResult RemoveUser(string userId)
        //{
        //    try
        //    {
        //        _rep.RemoveUser(userId);
        //        return Ok();
        //    }
        //    catch(Exception e)
        //    {
        //        return NotFound(e.Message);
        //    }
        //}
    }
}
