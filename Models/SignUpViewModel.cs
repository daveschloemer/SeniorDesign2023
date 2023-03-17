using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace FreshBooks.Models
{
    public class SignUpViewModel
    {
        [Required]
        [MinLength(2)]
        public string FirstName { get; set; }
        [Required]
        [MinLength(2)]
        public string LastName { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [EmailAddress]
        public string ConfirmEmail { get; set; }
        [Required]
        [MinLength(6, ErrorMessage = "Min Username 6 character")]
        [MaxLength(15, ErrorMessage = "Max Username 15 character")]
        public string Username { get; set; }
        [Required]
        [PasswordPropertyText]
        public string Password { get; set; }
        [Required]
        [PasswordPropertyText]
        public string ConfirmPassword { get; set; }
    }
}
