using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace FreshBooks.Models
{
    public class OrderViewModel
    {
        [Required(ErrorMessage = "Please Your Name")]
        [MinLength(2)]
        public string BuyerName { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public int BookID { get; set; }

        [Display(Name = "Phone")]
        [Required(ErrorMessage = "Please Your Phone Number")]
        public string Phone { get; set; }
        [Required]
        public string Edition { get; set; }
        [Required]
        public string BookTitle { get; set; }
        [Required]
        public string ISBN { get; set; }
        [Required]
        public string Price { get; set; }
        [Required]
        public string Author { get; set; }
        [Required]
        public string Subject { get; set; }
        [Required]
        public string imagesURL { get; set; }

        [Required(ErrorMessage = "Please select a location")]
        public string Location { get; set; }


        /*        [Required]
        *//*        public string UserName { get; set; }*/
    }
}
