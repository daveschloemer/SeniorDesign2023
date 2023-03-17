using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace FreshBooks.Models
{
    public class LoginViewModel
    {
        [Required]
        [MinLength(6, ErrorMessage = "Min Username 6 character")]
        [MaxLength(15, ErrorMessage = "Max Username 15 character")]
        public string Username { get; set; }
        [Required]
        [PasswordPropertyText]
        public string Password { get; set; }
    }
}