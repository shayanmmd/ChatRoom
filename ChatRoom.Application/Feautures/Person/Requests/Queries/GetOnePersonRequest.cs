using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChatRoom.Application.DTOs;
using ChatRoom.Application.DTOs.PersonDto;
using ChatRoom.Application.Responses;
using ChatRoom.Domain.Commons;
using MediatR;

namespace ChatRoom.Application.Feautures.Person.Requests.Queries
{
    public class GetOnePersonRequest : IRequest<PersonDto>, IHasGuid
    {
        public Guid Guid { get; set; }
    }
}
