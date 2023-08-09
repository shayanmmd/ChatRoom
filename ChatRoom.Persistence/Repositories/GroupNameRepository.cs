using ChatRoom.Application.Contracts.Persistence;
using ChatRoom.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatRoom.Persistence.Repositories
{
    public class GroupNameRepository : GenericRepository<GroupName>, IGroupNameRepository
    {
        private ChatRoomDbContext _dbcontext;

        public GroupNameRepository(ChatRoomDbContext context) : base(context)
        {
            _dbcontext = context;
        }
    }
}
