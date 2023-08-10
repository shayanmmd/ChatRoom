using AutoMapper;
using ChatRoom.Application.Contracts.Persistence;
using ChatRoom.Application.DTOs.GroupNameDto;
using ChatRoom.Application.Feautures.GroupName.Requests.Queries;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ChatRoom.Application.Feautures.GroupName.Handlers.Queries
{
    public class GetListGroupNameHandlers : IRequestHandler<GetListGroupNameRequest, List<GroupNameDto>>
    {
        private readonly IMapper _mapper;
        private readonly IGroupNameRepository _groupNameRepository;

        public GetListGroupNameHandlers(IMapper mapper,IGroupNameRepository groupNameRepository)
        {
            _mapper = mapper;
            _groupNameRepository = groupNameRepository;
        }

        public async Task<List<GroupNameDto>> Handle(GetListGroupNameRequest request, CancellationToken cancellationToken)
        {
            var res = await  _groupNameRepository.GetAllAsync();
            return _mapper.Map<List<GroupNameDto>>(res);
        }
    }
}
