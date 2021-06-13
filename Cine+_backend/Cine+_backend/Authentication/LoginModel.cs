using System.ComponentModel.DataAnnotations;

namespace Cine__backend.Authentication
{
    public class LoginModel
    {
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
