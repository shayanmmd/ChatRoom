using ChatRoom.Application.Contracts.Email;
using ChatRoom.Application.Models.Email;
using ChatRoom.Infrastructure.Emails;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
namespace ChatRoom.Infrastructure
{
    public static class InfrastructureServices
    {
        public static IServiceCollection ConfigureInfrastructureServices(this IServiceCollection services
             , IConfiguration configuration)
        {
            //services.Configure<EmailSetting>("", options => { configuration.GetSection("");});
            services.AddTransient<IEmail, EmailSender>();
            return services;
        }



    }
}
