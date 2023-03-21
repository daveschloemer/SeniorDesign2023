using System.ComponentModel.DataAnnotations;

namespace FreshBooks.Models
{
    public class ListedTabItem
    {

        [Key]
        public int Id { get; set; }

        public Book Book { get; set; }

        public int Amount { get; set; }


        public string ListedTabId { get; set; }
    }
}
