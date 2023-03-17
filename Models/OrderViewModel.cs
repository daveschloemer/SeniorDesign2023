using System.ComponentModel.DataAnnotations;

namespace FreshBooks.Models
{
    public class OrderViewModel
    {
        [Required]
        [MinLength(2)]
        public string Name { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        public string StudentID { get; set; }
        [Required]
        public string Number { get; set; }

    }
}
