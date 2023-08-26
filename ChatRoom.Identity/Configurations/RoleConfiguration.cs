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
    public class RoleConfiguration : IEntityTypeConfiguration<IdentityRole>
    {
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            builder.HasData(
                new IdentityRole
                {
                    Id = "51122807-3264-4fe1-9de0-3ffe94e19a1c",
                    Name = "User",
                    NormalizedName = "USERS"
                },
                new IdentityRole
                {
                    Id = "d5d85b38-2e86-465e-bc14-f1dc5873b1a2",
                    Name = "Admin",
                    NormalizedName = "ADMIN"
                }

                );
        }
    }
}
