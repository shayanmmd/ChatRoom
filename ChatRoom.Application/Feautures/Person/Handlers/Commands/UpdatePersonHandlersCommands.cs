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
    public class UpdatePersonHandlersCommands : IRequestHandler<UpdatePersonRequestCommands, BaseResponse>
    {
        private IPersonRepository _personRepository;
        private IMapper _mapper;
        public UpdatePersonHandlersCommands(IPersonRepository personRepository, IMapper mapper)
        {
            _personRepository = personRepository;
            _mapper = mapper;
        }

        public async Task<BaseResponse> Handle(UpdatePersonRequestCommands request, CancellationToken cancellationToken)
        {
            var res = new BaseResponse();
            try
            {
                #region Validation
                var validation = new UpdatePersonDtoValidator();
                var validationResult = await validation.ValidateAsync(request.OldPerson);
                if (!validationResult.IsValid)
                {
                    foreach (var err in validationResult.Errors)
                        res.AddError(err.ErrorMessage);
                    return res;
                }
                #endregion 
                var person = _mapper.Map<Domain.Person>(request.OldPerson);
                res = await _personRepository.UpdateAsync(person);
            }
            catch (Exception ex) { res.AddException(ex); }
            return res;
        }
    }
}
