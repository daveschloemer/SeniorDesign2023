using FreshBooks.Data.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FreshBooks.Models
{
    public class Book : IEntityBase
    {
        [Key]
        public int Id { get; set; }

        public string Edition { get; set; }
        public string Title { get; set; }
        public string ISBN { get; set; }
        public string Price { get; set; }
        public string Author { get; set; }
        public string Subject { get; set; }
        public string imagesURL { get; set; }


        public string UserId { get; set; }
        [ForeignKey(nameof(UserId))]
        public ApplicationUser User { get; set; }

        public string Email { get; set; }
/*        public int BookUserId { get; set; }
        [ForeignKey("BookUserId")]
        public BookUser BookUser { get; set; }*/

    }
}
