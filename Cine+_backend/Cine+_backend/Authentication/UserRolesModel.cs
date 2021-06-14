using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Cine__backend.Authentication
{
    public class UserRolesModel
    {
        [Required]
        public string Email { get; set; }
        [Required]
        public IList<string> Roles { get; set; }
    }
}
