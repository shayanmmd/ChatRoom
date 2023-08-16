using ChatRoom.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatRoom.Persistence
{
    public class ChatRoomDbContext : DbContext
    {
        public ChatRoomDbContext(DbContextOptions<ChatRoomDbContext> options) : base(options) { }


        DbSet<Person> Person { get; set; }
        DbSet<GroupName> GroupName { get; set; }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.ApplyConfigurationsFromAssembly(typeof(ChatRoomDbContext).Assembly);
        //}



    }
}
