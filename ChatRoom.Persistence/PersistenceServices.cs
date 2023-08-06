using ChatRoom.Application.Contracts;
using ChatRoom.Application.Persistence.Contracts;
using ChatRoom.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatRoom.Persistence
{
    public static class PersistenceServices
    {
        public static IServiceCollection ConfigurePersistenceServices(this IServiceCollection services
            , IConfiguration configuration)
        {
            services.AddDbContext<ChatRoomDbContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("ChatRoomConnectionString"));                
            });
            services.AddScoped(typeof(IGenericRepository<>),typeof(GenericRepository<>));
            services.AddScoped<IPersonRepository, PersonRepository>();
            return services;
        }
    }
}
