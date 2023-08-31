using ChatRoom.Domain;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace ChatRoom.Identity
{
    public class ChatRoomIdentityDbContext : IdentityDbContext
    {
        public ChatRoomIdentityDbContext(DbContextOptions options)
        : base(options) { }

    }
}
