using ChatRoom.Application.Contracts;
using ChatRoom.Application.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatRoom.Persistence.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private ChatRoomDbContext _dbContext;
        public GenericRepository(ChatRoomDbContext context)
        {
            _dbContext = context;
        }

        public async Task<BaseResponse> AddAsync(T item)
        {
            var res = new BaseResponse();
            try
            {
                _dbContext.Add(item);
                _dbContext.SaveChanges();
            }
            catch (Exception ex) { res.AddException(ex); }
            return res;
        }

        public async Task<BaseResponse> DeleteAsync(Guid guid)
        {
            var res = new BaseResponse();
            try
            {
                var entity = await GetAsync(guid);
                _dbContext.Remove(entity);
                _dbContext.SaveChanges();
            }
            catch (Exception ex) { res.AddException(ex); }
            return res;
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            try
            {
                return _dbContext.Set<T>().ToList();
            }
            catch (Exception ex) { throw new Exception(); }
            
        }

        public async Task<T> GetAsync(Guid guid)
        {
            try
            {
                return _dbContext.Set<T>().Single();
            }
            catch (Exception ex) { throw new Exception(); }
        }

        public async Task<BaseResponse> UpdateAsync(T item)
        {
            var res = new BaseResponse();
            try
            {
                _dbContext.Update(item);
            }
            catch (Exception ex) { res.AddException(ex); }
            return res;
        }
    }
}
