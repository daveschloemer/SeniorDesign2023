using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace FreshBooks.Data.ViewModels
{
    public class RegisterVM
    {
        [Display(Name = "Full Name")]
        [Required(ErrorMessage = "Full Name is Required")]
        public string FullName { get; set; }

        [Display(Name = "Email Address")]
        [Required(ErrorMessage = "Email Address is Required")]
        [RegularExpression(@"^[a-zA-Z0-9._%+-]+@mail\.uc\.edu$", ErrorMessage = "Please enter a valid email address on the mail.uc.edu domain.")]
        public string EmailAddress { get; set; }
  
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name = "Confirm Password")]
        [Required(ErrorMessage = "Confirm Password is Required")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Your Passwords do not match")]
        public string ConfirmPassword { get; set; }
    }
}
