using System.Runtime.CompilerServices;
using System.Text;
using Core.Models.EfModels.Base;
using Core.Models.Requests.Base;
using Core.Resources;
using Microsoft.Extensions.Localization;
using ReActionResponse.Core;
using ReFilter.Models;
using Workspaces.Application.Services.Base;
using Workspaces.Core.Models.EfModels;
using Workspaces.Core.Models.Requests.Workspace;
using Workspaces.Core.Models.ViewModels.Workspace;
using Workspaces.Core.Services.Contracts;

namespace Workspaces.Application.Services.Implementations
{
    internal class WorkspaceService : IWorkspaceService
    {
        #region Ctors and Members

        private readonly IServiceBase serviceBase;
        private readonly IStringLocalizer<ValidationResources> validationLocalizer;

        public WorkspaceService(
            IServiceBase serviceBase,
            IStringLocalizer<ValidationResources> validationLocalizer)
        {
            this.validationLocalizer = validationLocalizer;
            this.serviceBase = serviceBase;
            this.serviceBase.ValidateFunction = delegate (DatabaseEntity s) { return Validate<Workspace, Guid>(Unsafe.As<Workspace>(s)); };
        }

        #endregion Ctors and Members

        #region Readers

        public async Task<ActionResponse<WorkspaceViewModel>> Get(Guid id)
        {
            return await serviceBase.Get<WorkspaceViewModel, Workspace, Guid>(id);
        }

        public async Task<ActionResponse<List<WorkspaceViewModel>>> GetAll()
        {
            return await serviceBase.GetAll<WorkspaceViewModel, Workspace, Guid>();
        }

        public async Task<ActionResponse<PagedResult<WorkspaceViewModel>>> GetPaged(BasePagedRequest request)
        {
            return await serviceBase.GetPaged<WorkspaceViewModel, Workspace, Guid>(request);
        }

        #endregion Readers

        #region Writers

        public async Task<ActionResponse<Guid>> Create(WorkspaceCreateRequest request)
        {
            return await serviceBase.Create<Workspace, Guid>(request);
        }

        public async Task<ActionResponse> Delete(BaseWriteRequest<Guid> request)
        {
            return await serviceBase.Delete<Workspace, Guid>(request);
        }

        public async Task<ActionResponse> Update(WorkspaceUpdateRequest request)
        {
            return await serviceBase.Update<Workspace, Guid>(request);
        }

        #endregion Writers

        #region Validators and Helpers

        public ActionResponse Validate<T, U>(T entity)
            where T : DatabaseEntity<U>
            where U : struct
        {
            try
            {
                var response = ActionResponse.Success();

                return response;
            }
            catch (Exception ex)
            {
                var message = $"{serviceBase.StringLocalizer.GetString(Resources.CriticalError)} {serviceBase.StringLocalizer.GetString(Resources.PleaseContactYourAdministrators)}";
                serviceBase.Logger.LogError(message, ex, entity);
                return ActionResponse.Error(Message: message);
            }
        }

        private ActionResponse DeleteCheck<T, U>(BaseWriteRequest<Guid> request)
            where T : DatabaseEntity<U>
            where U : struct
        {
            try
            {
                return ActionResponse.Success();
            }
            catch (Exception ex)
            {
                var message = $"{serviceBase.StringLocalizer.GetString(Resources.CriticalError)} {serviceBase.StringLocalizer.GetString(Resources.PleaseContactYourAdministrators)}";
                return serviceBase.Logger.LogError(message, ex, request);
            }
        }

        #endregion Validators and Helpers
    }
}
