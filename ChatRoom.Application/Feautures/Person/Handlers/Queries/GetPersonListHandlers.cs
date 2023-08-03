using AutoMapper;
using ChatRoom.Application.DTOs;
using ChatRoom.Application.Feautures.Person.Requests;
using ChatRoom.Application.Persistence.Contracts;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace ChatRoom.Application.Feautures.Person.Handlers.Queries
{
    public class GetPersonListHandlers : IRequestHandler<GetPersonListRequest, List<PersonDto>>
    {
        private IMapper _mapper;
        private IPersonRepository _personRepository;
        public GetPersonListHandlers(IPersonRepository personRepository, IMapper mapper)
        {
            _personRepository = personRepository;
            _mapper = mapper;
        }
        public async Task<List<PersonDto>> Handle(GetPersonListRequest request, CancellationToken cancellationToken)
        {
            var res = await _personRepository.GetAllAsync();
            return _mapper.Map<List<PersonDto>>(res);
        }
    }
}
