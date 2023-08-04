using AutoMapper;
using ChatRoom.Application.Feautures.Person.Requests.Commands;
using ChatRoom.Application.Persistence.Contracts;
using MediatR;
using System.Threading;
using System.Threading.Tasks;
using ChatRoom.Domain.Commons;
using ChatRoom.Domain;


namespace ChatRoom.Application.Feautures.Person.Handlers.Commands
{
    public class CreatePersonHandlersCommands : IRequestHandler<CreatePersonRequestCommands, int>
    {
        private IPersonRepository _personRepository;
        private IMapper _mapper;

        public CreatePersonHandlersCommands(IPersonRepository personRepository, IMapper mapper)
        {
            _personRepository = personRepository;
            _mapper = mapper;
        }

        public async Task<int> Handle(CreatePersonRequestCommands request, CancellationToken cancellationToken)
        {
            var person = _mapper.Map<Domain.Person>(request.newPerson);
            return await _personRepository.SaveAsync(person);
        }
    }
}
