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
    public class GroupNameService : BaseHttpService, IGroupName
    {
        private readonly IMapper _mapper;
        private readonly IClient _client;
        private readonly ILocalStorage _localStorage;

        public GroupNameService(IMapper mapper ,IClient client, ILocalStorage localStorage) : base(client, localStorage)
        {
            _mapper = mapper;
            _client = client;
            _localStorage = localStorage;
        }

        public Task<ChatRoom.Application.Responses.BaseResponse> AddAsync(GroupNameVM item)
        {
            throw new NotImplementedException();
        }

        public Task<ChatRoom.Application.Responses.BaseResponse> DeleteAsync(GroupNameVM item)
        {
            throw new NotImplementedException();
        }

        public Task<List<GroupNameVM>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<GroupNameVM> GetAsync()
        {
            throw new NotImplementedException();
        }

        public Task<ChatRoom.Application.Responses.BaseResponse> UpdateAsync(GroupNameVM item)
        {
            throw new NotImplementedException();
        }
    }
}
