using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatRoom.Application.Contracts
{
    public interface IGenericRepository<T> where T : class
    {
        Task<T> GetAsync(Guid guid);
        Task<IEnumerable<T>> GetAllAsync();
        Task SaveAsync(T item);
        Task DeleteAsync(Guid guid);
    }
}
