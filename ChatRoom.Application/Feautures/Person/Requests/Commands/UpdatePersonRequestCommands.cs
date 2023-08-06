using ChatRoom.Application.DTOs.PersonDto;
using ChatRoom.Application.Responses;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatRoom.Application.Feautures.Person.Requests.Commands
{
    public class UpdatePersonRequestCommands : IRequest<BaseResponse>
    {
        public PersonDto OldPerson { get; set; }
    }
}
