using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Cards.Infrastructure.EfContext;

namespace Cards.Infrastructure
{
    public static class HostingExtensions
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddHttpContextAccessor();

            services.AddDbContext<CardsContext>(options => options.UseSqlServer(configuration.GetConnectionString(nameof(CardsContext))));

            return services;
        }
    }
}
