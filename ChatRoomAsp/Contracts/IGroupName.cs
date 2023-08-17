using ChatRoom.Application.Responses;
using ChatRoomAsp.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChatRoomAsp.Contracts
{
    public interface IGroupName
    {
        Task<List<GroupNameVM>> GetAllAsync();
        Task<GroupNameVM> GetAsync();
        Task<BaseResponse> AddAsync(GroupNameVM item);
        Task<BaseResponse> UpdateAsync(GroupNameVM item);
        Task<BaseResponse> DeleteAsync(GroupNameVM item);
    }
}
