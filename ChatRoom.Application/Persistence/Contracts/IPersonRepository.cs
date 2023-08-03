using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChatRoom.Application.Contracts;
using ChatRoom.Application.DTOs;
using ChatRoom.Application.Persistence.Contracts;
using ChatRoom.Domain;

namespace ChatRoom.Application.Persistence.Contracts
{
    public interface IPersonRepository : IGenericRepository<Person>
    {
    }
}
