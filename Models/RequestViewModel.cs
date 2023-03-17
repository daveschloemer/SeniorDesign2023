using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace FreshBooks.Models
{
    public class RequestViewModel
    {
        [Required]
        public string Title { get; set; }
        [Required]
        public string Author { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        public string ISBN { get; set; }
        [Required]
        public string BookSubject { get; set; }
        [Required]
        public string Edition { get; set; }
        [Required]
        public string Price { get; set; }
        [Required]
        public string username { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
    }
}
