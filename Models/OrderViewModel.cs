using System.ComponentModel.DataAnnotations;

namespace FreshBooks.Models
{
    public class OrderViewModel
    {
        [Required]
        [MinLength(2)]
        public string BuyerName { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        public int BookID { get; set; }
        [Required]
        public string BuyerEmail { get; set; }

    }
}
