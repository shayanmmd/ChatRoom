using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using ChatRoom.Application.DTOs.PersonDto.Validators;
using ChatRoom.Application.Feautures.Person.Requests.Commands;
using ChatRoom.Application.Persistence.Contracts;
using MediatR;

namespace ChatRoom.Application.Feautures.Person.Handlers.Commands
{
    public class DeletePersonHandlersCommands : IRequestHandler<DeletePersonRequestCommands, Guid>
    {
        private IPersonRepository _personRepository;

        public DeletePersonHandlersCommands(IPersonRepository personRepository,IMapper mapper)
        {
            _personRepository = personRepository;
        }

        public async Task<Guid> Handle(DeletePersonRequestCommands request, CancellationToken cancellationToken)
        {
            var validation = new DeletePersonDtoValidator();
            var validationresult = await validation.ValidateAsync(request.oldPerson);
            return await _personRepository.DeleteAsync(request.oldPerson.Guid);
        }
    }
}
