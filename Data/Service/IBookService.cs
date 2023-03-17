using FreshBooks.Data.Base;
using FreshBooks.Models;

namespace FreshBooks.Data.Service
{
    public interface IBookService:IEntityBaseRepository<Book>
    {
        Task<Book> GetBookAsync(int id);
    }
}
