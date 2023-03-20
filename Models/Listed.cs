using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FreshBooks.Models
{
    public class Listed
    {
        [Key]
        public int Id { get; set; }

        public string Email { get; set; }

        public string UserID { get; set; }


        public List<ListedItem> ListedItems { get; set; }
    }
}
