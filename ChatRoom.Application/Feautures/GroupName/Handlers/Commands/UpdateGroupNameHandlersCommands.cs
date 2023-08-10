using AutoMapper;
using ChatRoom.Application.Contracts.Persistence;
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
    public class UpdateGroupNameHandlersCommands : IRequestHandler<UpdateGroupNameRequestCommands, BaseResponse>
    {
        private readonly IMapper _mapper;
        private readonly IGroupNameRepository _groupNameRepository;

        public UpdateGroupNameHandlersCommands(IMapper mapper, IGroupNameRepository groupNameRepository)
        {
            _mapper = mapper;
            _groupNameRepository = groupNameRepository;
        }
        public async Task<BaseResponse> Handle(UpdateGroupNameRequestCommands request, CancellationToken cancellationToken)
        {
            var res = new BaseResponse();
            try
            {
                #region Validation
                var validation = new DTOs.GroupNameDto.Validators.UpdateGroupNameValidator();
                var validator = await validation.ValidateAsync(request.OldGroupName);
                if (!validator.IsValid)
                {
                    foreach (var item in validator.Errors)
                        res.AddError(item.ErrorMessage);
                    return res;
                }
                #endregion
                var groupName = _mapper.Map<Domain.GroupName>(request.OldGroupName);
                res = await _groupNameRepository.UpdateAsync(groupName);
            }
            catch (Exception ex)
            {
                res.AddException(ex);
            }
            return res;
        }
    }
}
