using FreshBooks.Data.Base;
using FreshBooks.Models;
using Microsoft.EntityFrameworkCore;
using System.Drawing;

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
            var bookDetails = await _context.Book.FirstOrDefaultAsync(c => c.Id == id);
/*                .Include(a => a.Author_Books).ThenInclude(b => b.Author)
                .FirstOrDefaultAsync(c => c.Id == id);*/
            return bookDetails;
        }

        public async Task AddNewBookAsync(NewBookVM data)
        {
            var newBook = new Book()
            {
                Title = data.Title,
                Edition = data.Edition,
                ISBN = data.ISBN,
                imagesURL = data.imagesURL,
                Price = data.Price
            };
            await _context.Book.AddAsync(newBook);
            await _context.SaveChangesAsync();

            //Authors

        }
    }
}
