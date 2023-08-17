using AutoMapper;
using ChatRoomAsp.Contracts;
using ChatRoomAsp.Models.Entities;
using ChatRoomAsp.Services.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChatRoomAsp.Services
{
    public class GroupNameService : BaseHttpService, IGroupNameService
    {
        private readonly IMapper _mapper;
        private readonly IClient _client;
        private readonly ILocalStorage _localStorage;

        public GroupNameService(IMapper mapper, IClient client, ILocalStorage localStorage) : base(client, localStorage)
        {
            _mapper = mapper;
            _client = client;
            _localStorage = localStorage;
        }

        public async Task<ChatRoom.Application.Responses.BaseResponse> AddAsync(GroupNameVM item)
        {
            var res = new ChatRoom.Application.Responses.BaseResponse();
            try
            {
                var groupNameDto = _mapper.Map<GroupNameDto>(item);
                var ret = await _client.AddGroupNameAsync(groupNameDto);
                if (ret.HasError)
                    res.ErrorMessages = ret.ErrorMessages.ToList();
            }
            catch (Exception ex) { res.AddException(ex); }
            return res;
        }

        public async Task<ChatRoom.Application.Responses.BaseResponse> DeleteAsync(GroupNameVM item)
        {
            var res = new ChatRoom.Application.Responses.BaseResponse();
            try
            {
                var groupNameDto = _mapper.Map<GroupNameDto>(item);
                var ret = await _client.DeleteGroupNameAsync(groupNameDto);
                if (ret.HasError)
                    res.ErrorMessages = ret.ErrorMessages.ToList();
            }
            catch (Exception ex) { res.AddException(ex); }
            return res;
        }

        public async Task<List<GroupNameVM>> GetAllAsync()
        {
            var res = await _client.GetAllGroupNameAsync();
            return _mapper.Map<List<GroupNameVM>>(res);
        }

        public async Task<GroupNameVM> GetAsync(Guid guid)
        {
            var res = await _client.GetGroupNameAsync(guid);
            return _mapper.Map<GroupNameVM>(res);
        }

        public async Task<ChatRoom.Application.Responses.BaseResponse> UpdateAsync(GroupNameVM item)
        {
            var res = new ChatRoom.Application.Responses.BaseResponse();
            try
            {
                var groupNameDto = _mapper.Map<GroupNameDto>(item);
                var ret = await _client.UpdateGroupNameAsync(groupNameDto);
                if (ret.HasError)
                    res.ErrorMessages = ret.ErrorMessages.ToList();
            }
            catch (Exception ex) { res.AddException(ex); }
            return res;
        }
    }
}
