using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Workspaces.Infrastructure.EfContext;

namespace Workspaces.Infrastructure
{
    public static class HostingExtensions
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            //services.AddHttpContextAccessor();

            services.AddDbContext<WorkspacesDbContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString(nameof(WorkspacesDbContext))));

            return services;
        }
    }
}
