using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using ReFilter.Extensions;
using Workspaces.Application.ReFilter.Filtering.Builders;
using Workspaces.Application.ReFilter.Sorting.Builders;
using Workspaces.Application.Repository;
using Workspaces.Application.Services.Base;
using Workspaces.Application.Services.Implementations;
using Workspaces.Application.Services.Implementations.Utility;
using Workspaces.Application.SignalR;
using Workspaces.Core.Services.Contracts;
using Workspaces.Core.Services.Contracts.SignalR;
using Workspaces.Core.Services.Contracts.Utility;
using Workspaces.Infrastructure.Repository.UnitOfWork;

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
            services.TryAddTransient<IUnitOfWork, UnitOfWork>();

            services.TryAddTransient<IWorkspaceService, WorkspaceService>();

            #endregion Services

            #region ReFilters

            services.AddReFilter(typeof(ReFilterConfigBuilder), typeof(ReSortConfigBuilder));

            #endregion ReFilters

            return services;
        }
    }
}
