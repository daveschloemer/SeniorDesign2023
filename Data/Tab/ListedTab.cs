using FreshBooks.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace FreshBooks.Data.Tab
{
    public class ListedTab
    {
        public BookDbContext _context { get; set; }

        public string ListedTabId { get; set; }
        public List<ListedTabItem> ListedTabItems { get; set; }

        public ListedTab(BookDbContext context)
        {
            _context = context;
        }

        public void AddItemToTab(Book book)
        {
            var listedTabItem = _context.ListedTabItems.FirstOrDefault(n => n.Book.Id == book.Id && n.ListedTabId == ListedTabId);

            if (listedTabItem == null)
            {
                listedTabItem = new ListedTabItem()
                {
                    ListedTabId = ListedTabId,
                    Book = book,
                    Amount = 1
                };
                _context.ListedTabItems.Add(listedTabItem);
            } else
            {
                listedTabItem.Amount++;
            }
            _context.SaveChanges();
        }

        public void RemoveItemFromTab(Book book)
        {
            var listedTabItem = _context.ListedTabItems.FirstOrDefault(n => n.Book.Id == book.Id && n.ListedTabId == ListedTabId);

            if (listedTabItem != null)
            {
                if(listedTabItem.Amount > 1) 
                {
                    listedTabItem.Amount--;
                }else
                {
                    _context.ListedTabItems.Remove(listedTabItem);
                }
                listedTabItem = new ListedTabItem()
                {
                    ListedTabId = ListedTabId,
                    Book = book,
                    Amount = 1
                };

                _context.ListedTabItems.Add(listedTabItem);
            }
            _context.SaveChanges();
        }
        public List<ListedTabItem> GetListedTabItems()
        {
            return ListedTabItems ?? (ListedTabItems = _context.ListedTabItems.Where(n => n.ListedTabId == ListedTabId).Include(n => n.Book).ToList());
        }
    }
}
