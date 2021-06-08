using Cine__backend.Interfaces;
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
    public class UserFilmController : ControllerBase
    {
        private IUserFilmRepository _userFilmRep;
        public UserFilmController(IUserFilmRepository userFilmRepository)
        {
            this._userFilmRep = userFilmRepository;
        }
    }
}
