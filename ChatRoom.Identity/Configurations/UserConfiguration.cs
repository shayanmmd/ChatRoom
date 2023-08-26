using ChatRoom.Identity.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatRoom.Identity.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<ApplicationUser>
    {
        public void Configure(EntityTypeBuilder<ApplicationUser> builder)
        {
            var hasher = new PasswordHasher<ApplicationUser>();
            builder.HasData(

                new ApplicationUser
                {
                    Id = "51122807-3264-4fe1-9de0-3ffe94e19a1f",
                    Email = "admin@localhost.com",
                    NormalizedEmail = "ADMIN@LOCALHOST.COM",
                    Name = "Admin",
                    UserName = "admin@localhost.com",
                    NormalizedUserName = "ADMIN@LOCALHOST.COM",
                    PasswordHash = hasher.HashPassword(null, "P@ssword1")
                },
                  new ApplicationUser
                  {
                      Id = "51122807-3264-4fe1-9de0-3ffe94e19a2D",
                      Email = "user@localhost.com",
                      NormalizedEmail = "USER@LOCALHOST.COM",
                      Name = "User",
                      UserName = "user@localhost.com",
                      NormalizedUserName = "USER@LOCALHOST.COM",
                      PasswordHash = hasher.HashPassword(null, "P@ssword2")
                  }
                );
        }
    }
}
