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
    public class UserRoleConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            builder.HasData(
                new IdentityUserRole<string>
                {
                    UserId = "51122807-3264-4fe1-9de0-3ffe94e19a2D",
                    RoleId = "51122807-3264-4fe1-9de0-3ffe94e19a1c"
                },
                new IdentityUserRole<string>
                {
                    UserId = "51122807-3264-4fe1-9de0-3ffe94e19a1f",
                    RoleId = "d5d85b38-2e86-465e-bc14-f1dc5873b1a2"
                }
                );
        }
    }
}
