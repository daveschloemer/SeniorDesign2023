using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FreshBooks.Models
{
    public class Book
    {
        [Key]
        public int BookId { get; set; }

        public string Edition { get; set; }
        public string Title { get; set; }
        public string ISBN { get; set; }
        public string Price { get; set; }
        public string imagesURL { get; set; }

        public List<Author_Books> Author_Books { get; set; }

        public int SubjectId { get; set; }
        [ForeignKey("SubjectId")]

        public Subject Subject { get; set; }
    }
}
