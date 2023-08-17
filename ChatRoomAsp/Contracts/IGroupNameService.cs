using ChatRoom.Application.Responses;
using ChatRoomAsp.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChatRoomAsp.Contracts
{
    public interface IGroupNameService
    {
        Task<List<GroupNameVM>> GetAllAsync();
        Task<GroupNameVM> GetAsync(Guid guid);
        Task<BaseResponse> AddAsync(GroupNameVM item);
        Task<BaseResponse> UpdateAsync(GroupNameVM item);
        Task<BaseResponse> DeleteAsync(GroupNameVM item);
    }
}
