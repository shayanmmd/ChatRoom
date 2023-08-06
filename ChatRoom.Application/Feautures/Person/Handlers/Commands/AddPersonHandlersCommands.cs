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
using ChatRoom.Application.Responses;
using ChatRoom.Application.Contracts.Email;
using ChatRoom.Application.Models.Email;

namespace ChatRoom.Application.Feautures.Person.Handlers.Commands
{
    public class AddPersonHandlersCommands : IRequestHandler<AddPersonRequestCommands, BaseResponse>
    {
        private IPersonRepository _personRepository;
        private IMapper _mapper;
        private IEmail _email;

        public AddPersonHandlersCommands(IPersonRepository personRepository, IMapper mapper,IEmail email)
        {
            _personRepository = personRepository;
            _mapper = mapper;
            _email = email;
        }

        public async Task<BaseResponse> Handle(AddPersonRequestCommands request, CancellationToken cancellationToken)
        {
            var res = new BaseResponse();
            try
            {
                #region Validation
                var validation = new AddPersonDtoValidator();
                var validationResult = await validation.ValidateAsync(request.newPerson);
                if (!validationResult.IsValid)
                {
                    foreach (var item in validationResult.Errors)
                        res.AddError(item.ErrorMessage);
                    return res;
                }
                #endregion
                var person = _mapper.Map<Domain.Person>(request.newPerson);
                res = await _personRepository.AddAsync(person);
                #region Send An Email
                var email = new Email
                {
                    To = request.newPerson.Name,
                    FromAddress = EmailSetting.FromAddress,
                    FromName = EmailSetting.FromName
                };
                res = await _email.SendEmailAsync(email);
                #endregion
            }
            catch (Exception ex) { res.AddException(ex); }
            return res;
        }
    }
}
