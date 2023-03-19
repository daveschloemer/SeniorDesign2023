using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FreshBooks.Models
{
    public class ListedItem
    {
        [Key]
        public int Id { get; set; }

        public int Amount { get; set; }

        public int BookId { get; set; }
        [ForeignKey("BookId")]
        public Book Book { get; set; }


        public int ListedId { get; set; }
        [ForeignKey("ListedId")]
        public Listed Listed { get; set; }
    }
}
