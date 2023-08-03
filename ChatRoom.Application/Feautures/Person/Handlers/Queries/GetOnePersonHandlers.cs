using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using ChatRoom.Application.DTOs;
using ChatRoom.Application.Feautures.Person.Requests;
using ChatRoom.Application.Persistence.Contracts;
using MediatR;
using AutoMapper;

namespace ChatRoom.Application.Feautures.Person.Handlers.Queries
{
    public class GetOnePersonHandlers : IRequestHandler<GetOnePersonRequest, PersonDto>
    {
        private IPersonRepository _personRepository;
        private IMapper _mapper;
        public GetOnePersonHandlers(IPersonRepository personRepository, IMapper mapper)
        {
            _personRepository = personRepository;
            _mapper = mapper;
        }
        public async Task<PersonDto> Handle(GetOnePersonRequest request, CancellationToken cancellationToken)
        {
            var res = await _personRepository.GetAsync(request.Guid);
            return _mapper.Map<PersonDto>(res);
        }
    }
}
