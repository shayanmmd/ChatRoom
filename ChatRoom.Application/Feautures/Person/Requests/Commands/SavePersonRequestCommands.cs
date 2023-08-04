using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChatRoom.Application.DTOs;
using ChatRoom.Application.DTOs.PersonDto;
using MediatR;

namespace ChatRoom.Application.Feautures.Person.Requests.Commands
{
    public class SavePersonRequestCommands : IRequest<Guid>
    {
        public PersonDto newPerson { get; set; }
    }
}
