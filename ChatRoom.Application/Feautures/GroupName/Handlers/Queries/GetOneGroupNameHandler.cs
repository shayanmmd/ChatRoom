using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using ChatRoom.Application.Contracts.Persistence;
using ChatRoom.Application.DTOs.GroupNameDto;
using ChatRoom.Application.Feautures.GroupName.Requests.Queries;
using ChatRoom.Application.Responses;
using MediatR;

namespace ChatRoom.Application.Feautures.GroupName.Handlers.Queries
{
    public class GetOneGroupNameHandler : IRequestHandler<GetOneGroupNameRequest, GroupNameDto>
    {
        private IMapper _mapper;
        private IGroupNameRepository _iGroupNameRepository;
        public GetOneGroupNameHandler(IGroupNameRepository groupNameRepository, IMapper mapper)
        {
            _mapper = mapper;
            _iGroupNameRepository = groupNameRepository;
        }

        public async Task<GroupNameDto> Handle(GetOneGroupNameRequest request, CancellationToken cancellationToken)
        {
            var res = await _iGroupNameRepository.GetAsync(request.Guid);
            return _mapper.Map<GroupNameDto>(res);
        }
    }
}
