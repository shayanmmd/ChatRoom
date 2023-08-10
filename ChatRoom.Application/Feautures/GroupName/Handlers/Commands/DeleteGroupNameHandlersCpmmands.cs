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
    public class DeleteGroupNameHandlersCpmmands : IRequestHandler<DeleteGroupNameRequestCommands, BaseResponse>
    {
        private readonly IMapper _mapper;
        private readonly IGroupNameRepository _groupNameRepository;

        public DeleteGroupNameHandlersCpmmands(IMapper mapper,IGroupNameRepository groupNameRepository)
        {
            _mapper = mapper;
            _groupNameRepository = groupNameRepository;
        }
        public async Task<BaseResponse> Handle(DeleteGroupNameRequestCommands request, CancellationToken cancellationToken)
        {
            var res = new BaseResponse();
            try
            {
                #region Validation
                var validation = new DeleteGroupNameValidator();
                var validator = await validation.ValidateAsync(request.OldGroupName);
                if (!validator.IsValid)
                {
                    foreach (var item in validator.Errors)
                        res.AddError(item.ErrorMessage);
                    return res;
                }
                #endregion 
                var groupName = _mapper.Map<Domain.GroupName>(request.OldGroupName);
                res = await _groupNameRepository.DeleteAsync(request.OldGroupName.Guid);
            }
            catch (Exception ex)
            {
                res.AddException(ex);
            }
            return res;
        }
    }
}
