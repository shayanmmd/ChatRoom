using ChatRoom.Application.DTOs.GroupNameDto;
using ChatRoom.Application.Responses;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatRoom.Application.Feautures.GroupName.Requests.Commands
{
    public class AddGroupNameRequestCommands : IRequest<BaseResponse>
    {
        public GroupNameDto NewgroupName{ get; set; }
    }
}
