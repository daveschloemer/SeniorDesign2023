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
            return bookDetails;
        }

        public async Task AddNewBookAsync(NewBookVM data, string userId, string userEmail, string userName)
        {

            var newBook = new Book()
            {
                Title = data.Title,
                Edition = data.Edition,
                ISBN = data.ISBN,
                imagesURL = data.imagesURL,
                Price = data.Price,
                Author = data.Author,
                Subject = data.Subject,
                UserId = userId,
                Email = userEmail,
                UserName = userName
            };
            await _context.Book.AddAsync(newBook);
            await _context.SaveChangesAsync();

        }

        public async Task<List<Book>> GetBooksByUserIdAsync(string userId)
        {
            var sellBook = await _context.Book.Where(n => n.UserId == userId).ToListAsync();
            return sellBook;
        }
        public async Task DeleteBookAsync(int id)
        {
            var deletebook = await _context.Book.FindAsync(id);

            if (deletebook != null)
            {
                _context.Book.Remove(deletebook);
                await _context.SaveChangesAsync();
            }
        }
    }
}
