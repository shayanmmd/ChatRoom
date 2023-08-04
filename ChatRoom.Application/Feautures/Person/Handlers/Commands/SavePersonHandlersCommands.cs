﻿using AutoMapper;
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

namespace ChatRoom.Application.Feautures.Person.Handlers.Commands
{
    public class SavePersonHandlersCommands : IRequestHandler<SavePersonRequestCommands, BaseResponse>
    {
        private IPersonRepository _personRepository;
        private IMapper _mapper;

        public SavePersonHandlersCommands(IPersonRepository personRepository, IMapper mapper)
        {
            _personRepository = personRepository;
            _mapper = mapper;
        }

        public async Task<BaseResponse> Handle(SavePersonRequestCommands request, CancellationToken cancellationToken)
        {
            var res = new BaseResponse();
            try
            {
                #region Validation
                var validation = new SavePersonDtoValidator();
                var validationResult = await validation.ValidateAsync(request.newPerson);
                if (!validationResult.IsValid)
                {
                    foreach (var item in validationResult.Errors)
                        res.AddError(item.ErrorMessage);
                    return res;
                }
                #endregion
                var person = _mapper.Map<Domain.Person>(request.newPerson);
                res = await _personRepository.SaveAsync(person);
            }
            catch (Exception ex) { res.AddException(ex); }
            return res;
        }
    }
}