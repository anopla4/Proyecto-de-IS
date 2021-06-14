using Cine__backend.Authentication;
using Cine__backend.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
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

        [Authorize(Roles = UserRoles.WebMaster)]
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

        [Authorize(Roles = UserRoles.WebMaster)]
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

        [HttpGet]
        [Authorize(Roles = UserRoles.WebMaster)]
        public async Task<IActionResult> GetUsersAsync()
        {
            return Ok(await _userRep.GetUsersAsync());
        }

        [HttpGet("{userId}")]
        [Authorize(Roles = UserRoles.WebMaster)]
        public async Task<IActionResult> GetUserByIdAsync(string userId)
        {
            try
            {
                var user = await _userRep.GetUserByIdAsync(userId);
                return Ok(user);
            }
            catch (Exception e)
            {
                return NotFound(e.Message);
            }
        }

        [HttpDelete("{userId}")]
        [Authorize(Roles = UserRoles.WebMaster)]
        public async Task<IActionResult> RemoveUserByIdAsync(string userId)
        {
            try
            {
                await _userRep.RemoveUserByIdAsync(userId);
                return Ok();
            }
            catch (Exception e)
            {
                return NotFound(e.Message);
            }
        }
    }
}
