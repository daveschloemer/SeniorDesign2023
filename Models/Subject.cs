using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations;

namespace FreshBooks.Models
{
    public class Subject
    {
        [Key]
        public int SubjectId { get; set; }

        public string Subjects { get; set; }

        public List<Book> Books { get; set; }
    }
}