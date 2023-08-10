using ChatRoom.Application.DTOs.GroupNameDto;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatRoom.Application.Feautures.GroupName.Requests.Queries
{
    public class GetListGroupNameRequest : IRequest<List<GroupNameDto>>
    {        
    }
}
