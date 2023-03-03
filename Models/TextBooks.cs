using FreshBooks.Data.Enum;
using System.ComponentModel.DataAnnotations;

namespace FreshBooks.Models
{
    public class TextBooks
    {
        [Key]
        public int Id { get; set; }

        public string BookTitle { get; set; }
        public string BookDescription { get; set; }
        public string BookISBN { get; set; }
        public string BookAuthor { get; set; }
        public decimal BookPrice { get; set; }
        public string BookSubject { get; set; }
        public string BookURL { get; set; }

        public School School { get; set; }
    }
}
