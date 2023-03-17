using System.ComponentModel.DataAnnotations;

namespace FreshBooks.Models
{
    public class ContactViewModel
    {
        [Required]
        [MinLength(2)]
        public string Name { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        public string Subject { get; set; }
        [Required]
        [MaxLength (1000, ErrorMessage ="Message is too long")]
        public string Message { get; set; }
    }
}
