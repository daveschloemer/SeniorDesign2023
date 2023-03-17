using FreshBooks.Data.Base;
using FreshBooks.Models;
using Microsoft.EntityFrameworkCore;

namespace FreshBooks.Data.Service
{
    public class BookService:EntityBaseRepository<Book>, IBookService
    {
        private readonly BookDbContext _context;
        public BookService(BookDbContext context) : base(context) 
        {
            _context= context;
        }

        public async Task<Book> GetBookAsync(int id)
        {
            var bookDetails =await _context.Book.Include(a => a.Author_Books).ThenInclude(b => b.Author)
                .FirstOrDefaultAsync(c => c.Id == id);
            return bookDetails;
        }
    }
}
