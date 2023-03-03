namespace FreshBooks.Models
{
    public class Author_Books
    {
        public int BookId { get; set; }
        public Book Book { get; set; }

        public int AuthorId { get; set; }
        public Author Author { get; set; }

    }
}
