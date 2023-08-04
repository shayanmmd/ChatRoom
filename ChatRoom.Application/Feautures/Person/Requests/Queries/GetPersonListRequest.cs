using ChatRoom.Application.DTOs;
using ChatRoom.Application.DTOs.PersonDto;
using MediatR;
using System.Collections.Generic;

namespace ChatRoom.Application.Feautures.Person.Requests.Queries
{
    public class GetPersonListRequest : IRequest<List<PersonDto>>
    {
    }
}
