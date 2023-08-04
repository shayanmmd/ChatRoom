using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChatRoom.Application.DTOs;
using ChatRoom.Application.DTOs.PersonDto;
using ChatRoom.Application.Responses;
using MediatR;

namespace ChatRoom.Application.Feautures.Person.Requests.Commands
{
    public class SavePersonRequestCommands : IRequest<BaseResponse>
    {
        public PersonDto newPerson { get; set; }
    }
}
