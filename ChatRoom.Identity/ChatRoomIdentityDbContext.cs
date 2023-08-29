using ChatRoom.Domain;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ChatRoom.Identity
{
    public class ChatRoomIdentityDbContext : DbContext
    {
        public ChatRoomIdentityDbContext(DbContextOptions<ChatRoomIdentityDbContext> options)
        : base(options) { }

        

    }
}
