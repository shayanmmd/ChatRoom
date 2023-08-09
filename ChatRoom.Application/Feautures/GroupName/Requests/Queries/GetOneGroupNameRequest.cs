using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChatRoom.Application.DTOs.GroupNameDto;
using ChatRoom.Domain.Commons;
using MediatR;


namespace ChatRoom.Application.Feautures.GroupName.Requests.Queries
{
    public class GetOneGroupNameRequest : IRequest<GroupNameDto>, IHasGuid
    {
        public Guid Guid { get; set; }
    }
}
