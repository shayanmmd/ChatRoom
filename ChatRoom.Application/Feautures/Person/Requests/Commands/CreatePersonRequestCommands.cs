using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChatRoom.Application.DTOs;
using MediatR;

namespace ChatRoom.Application.Feautures.Person.Requests.Commands
{
    public class CreatePersonRequestCommands : IRequest<int>
    {
        public PersonDto newPerson { get; set; }
    }
}
