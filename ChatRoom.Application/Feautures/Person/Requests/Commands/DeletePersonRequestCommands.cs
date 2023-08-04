using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace ChatRoom.Application.Feautures.Person.Requests.Commands
{
    public class DeletePersonRequestCommands : IRequest<Guid>
    {
        public Guid Guid { get; set; }
    }
}
