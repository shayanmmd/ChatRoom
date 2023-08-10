using AutoMapper;
using ChatRoom.Application.Contracts.Persistence;
using ChatRoom.Application.DTOs.GroupNameDto.Validators;
using ChatRoom.Application.Feautures.GroupName.Requests.Commands;
using ChatRoom.Application.Responses;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ChatRoom.Application.Feautures.GroupName.Handlers.Commands
{
    public class AddGroupNameHandlersCommands : IRequestHandler<AddGroupNameRequestCommands, BaseResponse>
    {
        private readonly IMapper _mapper;
        private readonly IGroupNameRepository _groupNameRepository;

        public AddGroupNameHandlersCommands(IMapper mapper,IGroupNameRepository groupNameRepository)
        {
            _mapper = mapper;
            _groupNameRepository = groupNameRepository;
        }
        public async Task<BaseResponse> Handle(AddGroupNameRequestCommands request, CancellationToken cancellationToken)
        {
            var res = new BaseResponse();
            try
            {
                #region Validation
                var validation = new AddGroupNameValidator();
                var validator = await validation.ValidateAsync(request.NewgroupName);
                if (!validator.IsValid)
                {
                    foreach (var item in validator.Errors)
                        res.AddError(item.ErrorMessage);
                    return res;
                }
                #endregion
                var newGroupName = _mapper.Map<Domain.GroupName>(request.NewgroupName);
                res = await _groupNameRepository.AddAsync(newGroupName);                
            }
            catch (Exception ex)
            {
                res.AddException(ex);
            }
            return res;
        }
    }
}
