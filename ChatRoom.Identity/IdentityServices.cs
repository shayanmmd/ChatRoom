using ChatRoom.Application.Contracts.Identity;
using ChatRoom.Identity.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;


namespace ChatRoom.Identity
{
    public static class IdentityServices
    {
        public static IServiceCollection ConfigureIdentityServices(this IServiceCollection services, IConfiguration configuration)
        {
            //services.AddIdentityCore<IdentityUser>()
            //    .AddEntityFrameworkStores<ChatRoomIdentityDbContext>()
            //    .AddDefaultTokenProviders();            
            services.AddDbContext<ChatRoomIdentityDbContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("ChatRoomConnectionString"));
            });
            services.AddSingleton<IAuthService, AuthService>();
            return services;
        }
    }
}
