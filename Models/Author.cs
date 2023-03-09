using System.ComponentModel.DataAnnotations;

namespace FreshBooks.Models
{
    public class Author
    {
        [Key]
        public int AuthorId { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public List<Author_Books> Author_Books { get; set; }
    }
}
