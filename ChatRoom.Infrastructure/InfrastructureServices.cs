using ChatRoom.Application.Contracts.Email;
using ChatRoom.Application.Models.Email;
using ChatRoom.Infrastructure.Emails;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ChatRoom.Infrastructure
{
    public static class InfrastructureServices
    {
        public static IServiceCollection ConfigureInfrastructureServices(this IServiceCollection services
             , IConfiguration configuration)
        {

            //services.Configure<EmailSetting>(configuration.GetSection(""));
            services.AddTransient<IEmail, EmailSender>(); 
            return services;
        }
      
      
      
    }
}
