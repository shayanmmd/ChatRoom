using AutoMapper;
using ChatRoom.Application.Feautures.Person.Requests.Commands;
using ChatRoom.Application.Persistence.Contracts;
using MediatR;
using System.Threading;
using System.Threading.Tasks;
using ChatRoom.Domain.Commons;
using ChatRoom.Domain;
using ChatRoom.Application.DTOs.PersonDto.Validators;
using System;

namespace ChatRoom.Application.Feautures.Person.Handlers.Commands
{
    public class CreatePersonHandlersCommands : IRequestHandler<CreatePersonRequestCommands, Guid>
    {
        private IPersonRepository _personRepository;
        private IMapper _mapper;

        public CreatePersonHandlersCommands(IPersonRepository personRepository, IMapper mapper)
        {
            _personRepository = personRepository;
            _mapper = mapper;
        }

        public async Task<Guid> Handle(CreatePersonRequestCommands request, CancellationToken cancellationToken)
        {
            #region Validation
            var validation = new PersonDtoValidator();
            var validationResult = await validation.ValidateAsync(request.newPerson);
            if (!validationResult.IsValid)
                throw new System.Exception();
            #endregion
            var person = _mapper.Map<Domain.Person>(request.newPerson);
            return await _personRepository.SaveAsync(person);
        }
    }
}
