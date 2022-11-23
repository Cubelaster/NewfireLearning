using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Workspaces.Application.Services.Base;
using Workspaces.Application.Services.Implementations.Utility;
using Workspaces.Application.SignalR;
using Workspaces.Core.Services.Contracts.SignalR;
using Workspaces.Core.Services.Contracts.Utility;

namespace Workspaces.Application
{
    public static class HostingExtensions
    {
        public static IServiceCollection AddApplication(this IServiceCollection services, IConfiguration configuration)
        {
            #region Services

            #region Utility

            services.TryAddScoped<IHttpContextService, HttpContextService>();
            services.TryAddScoped<IAppLogger, AppLogger>();
            services.TryAddScoped<IValidationService, ValidationService>();

            #endregion Utility

            #region SignalR

            services.TryAddScoped<IChangeNotifierService, ChangeNotifierService>();
            services.TryAddScoped<IFormAccessService, FormAccessService>();

            #endregion SignalR

            services.TryAddTransient<IServiceBase, ServiceBase>();



            #endregion Services

            #region ReFilters

            //services.AddReFilter(typeof(ReFilterConfigBuilder), typeof(ReSortConfigBuilder));

            #endregion ReFilters

            return services;
        }
    }
}
