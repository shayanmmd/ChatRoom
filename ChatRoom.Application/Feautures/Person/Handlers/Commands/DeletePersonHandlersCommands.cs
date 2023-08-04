using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using ChatRoom.Application.Feautures.Person.Requests.Commands;
using ChatRoom.Application.Persistence.Contracts;
using MediatR;

namespace ChatRoom.Application.Feautures.Person.Handlers.Commands
{
    public class DeletePersonHandlersCommands : IRequestHandler<DeletePersonRequestCommands, Guid>
    {
        private IPersonRepository _personRepository;
        private IMapper _mapper;

        public DeletePersonHandlersCommands(IPersonRepository personRepository,IMapper mapper)
        {
            _personRepository = personRepository;
            _mapper = mapper;
        }

        public async Task<Guid> Handle(DeletePersonRequestCommands request, CancellationToken cancellationToken)
        {
            var res = await _personRepository.DeleteAsync(request.Guid);
        }
    }
}
