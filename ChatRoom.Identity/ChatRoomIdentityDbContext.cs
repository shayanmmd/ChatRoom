﻿using ChatRoom.Identity.Configurations;
using ChatRoom.Identity.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatRoom.Identity
{
    class ChatRoomIdentityDbContext : IdentityDbContext<ApplicationUser>
    {
        public ChatRoomIdentityDbContext(DbContextOptions<ChatRoomIdentityDbContext> options)
        : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfiguration(new RoleConfiguration());
            builder.ApplyConfiguration(new UserRoleConfiguration());
            builder.ApplyConfiguration(new UserConfiguration());
        }
    }
}
