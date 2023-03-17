using Microsoft.AspNetCore.Identity;
using System.Linq.Expressions;

namespace FreshBooks.Data.Base
{
    public interface IEntityBaseRepository<T> where T: class, IEntityBase, new()
    {
        Task<IEnumerable<T>> GetAllAsync();
        Task<IEnumerable<T>> GetManyAsync(params Expression<Func<T, object>>[] includeProperties);

        Task<T> GetByIdAsync(int id);
        Task AddAsync(T enity);
        Task UpdateAsync(int id, T enity);

        Task DeleteAsync(int id);
    }
}
