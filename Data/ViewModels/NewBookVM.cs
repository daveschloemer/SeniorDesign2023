using FreshBooks.Data.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FreshBooks.Models
{
    public class NewBookVM
    {
        [Display(Name = "Book Edition")]
        [Required(ErrorMessage = "Please Input Edition or N/A")]
        public string Edition { get; set; }
        [Display(Name = "Book Title")]
        [Required(ErrorMessage = "Please Input Title")]
        public string Title { get; set; }

        [Display(Name = "Book ISBN")]
        [Required(ErrorMessage = "Please Input ISBN")]
        public string ISBN { get; set; }

        [Display(Name = "Book Price")]
        [Required(ErrorMessage = "Please Input Price")]
        public string Price { get; set; }

        [Display(Name = "ImagesURL")]
        [Required(ErrorMessage = "Please Input imagesURL")]
        public string imagesURL { get; set; }

        [Display(Name = "Author Name")]
        [Required(ErrorMessage = "Please Input Author")]
        public List<int> AuthorIds { get; set; }

    }
}
