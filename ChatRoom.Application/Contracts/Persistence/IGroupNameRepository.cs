using ChatRoom.Application.DTOs.GroupNameDto;
using ChatRoom.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatRoom.Application.Contracts.Persistence
{
    public interface IGroupNameRepository : IGenericRepository<GroupName>
    {
    }
}
