using System.ComponentModel.DataAnnotations;

namespace FreshBooks.Models
{
    public class BookUser
    {
        [Key]
        public int Id { get; set; }

        public string Email { get; set; }
        public string UserId { get; set; }

        public List<Book> Books { get; set; }
    }
}
