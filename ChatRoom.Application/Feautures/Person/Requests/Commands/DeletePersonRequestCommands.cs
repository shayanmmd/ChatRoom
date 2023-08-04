using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChatRoom.Application.DTOs.PersonDto;
using ChatRoom.Domain.Commons;
using MediatR;

namespace ChatRoom.Application.Feautures.Person.Requests.Commands
{
    public class DeletePersonRequestCommands : IRequest<Guid>
    {
        public PersonDto oldPerson { get; set; }
    }
}
