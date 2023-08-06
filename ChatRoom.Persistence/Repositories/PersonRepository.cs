using ChatRoom.Application.Contracts;
using ChatRoom.Application.Persistence.Contracts;
using ChatRoom.Application.Responses;
using ChatRoom.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatRoom.Persistence.Repositories
{
    public class PersonRepository : GenericRepository<Person>, IPersonRepository
    {
        private readonly ChatRoomDbContext _dbcontext;
        public PersonRepository(ChatRoomDbContext context) : base(context)
        {
            _dbcontext = context;
        }
    }
}
