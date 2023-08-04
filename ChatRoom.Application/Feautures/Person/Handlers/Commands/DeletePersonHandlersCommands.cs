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
using ChatRoom.Application.Responses;
using MediatR;

namespace ChatRoom.Application.Feautures.Person.Handlers.Commands
{
    public class DeletePersonHandlersCommands : IRequestHandler<DeletePersonRequestCommands, BaseResponse>
    {
        private IPersonRepository _personRepository;

        public DeletePersonHandlersCommands(IPersonRepository personRepository, IMapper mapper)
        {
            _personRepository = personRepository;
        }

        public async Task<BaseResponse> Handle(DeletePersonRequestCommands request, CancellationToken cancellationToken)
        {
            var res = new BaseResponse();
            try
            {
                #region Validation
                var validation = new DeletePersonDtoValidator();
                var validationresult = await validation.ValidateAsync(request.oldPerson);
                if (!validationresult.IsValid)
                {
                    foreach (var item in validationresult.Errors)
                    {
                        res.AddError(item.ErrorMessage);
                        return res;
                    }
                }
                #endregion
                res = await _personRepository.DeleteAsync(request.oldPerson.Guid);
            }
            catch (Exception ex) { res.AddException(ex); }
            return res;
        }
    }
}
