using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChatRoom.Application.DTOs;
using MediatR;

namespace ChatRoom.Application.Feautures.Person.Requests
{
    public class GetPersonListRequest : IRequest<List<PersonDto>>
    {
    }
}
