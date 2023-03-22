using FreshBooks.Data.Base;
using FreshBooks.Models;

namespace FreshBooks.Data.Service
{
    public interface IBookService:IEntityBaseRepository<Book>
    {
        Task<Book> GetBookAsync(int id);

        Task DeleteBookAsync(int id);
        Task AddNewBookAsync(NewBookVM data, string userId, string userEmail, string userName);

        Task<List<Book>> GetBooksByUserIdAsync(string userId);

    }
}
