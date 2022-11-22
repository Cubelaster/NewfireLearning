using System.Reflection;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Workspaces.Core
{
    public static class HostingExtensions
    {
        public static IServiceCollection AddCore(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddAutoMapper(Assembly.GetExecutingAssembly());

            ConfigureSettings(services, configuration);

            return services;
        }

        private static void ConfigureSettings(IServiceCollection services, IConfiguration configuration)
        {
            //services.Configure<ApplicationInfo>(configuration.GetSection(nameof(ApplicationInfo)));
            //services.Configure<ApplicationSettings>(configuration.GetSection(nameof(ApplicationSettings)));
            //services.Configure<JwtIssuerOptions>(configuration.GetSection(nameof(JwtIssuerOptions)));
            //services.Configure<MailSettings>(configuration.GetSection(nameof(MailSettings)));
        }
    }
}
