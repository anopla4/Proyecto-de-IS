using System.ComponentModel.DataAnnotations;

namespace Cine__backend.Authentication
{
    public class RegisterModel
    {
        [Required(ErrorMessage = "Se requiere un nombre de usuario")]
        public string Username { get; set; }

        [EmailAddress]
        [Required(ErrorMessage = "Se requiere un Email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Se requiere un password")]
        public string Password { get; set; }
    }
}
