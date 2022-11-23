using Core.Models.Requests.Base;
using ReActionResponse.Core;
using ReFilter.Models;
using Workspaces.Core.Models.Requests.Workspace;
using Workspaces.Core.Models.ViewModels.Workspace;

namespace Workspaces.Core.Services.Contracts
{
    public interface IWorkspaceService
    {
        Task<ActionResponse<Guid>> Create(WorkspaceCreateRequest request);
        Task<ActionResponse<WorkspaceViewModel>> Get(Guid id);
        Task<ActionResponse<List<WorkspaceViewModel>>> GetAll();
        Task<ActionResponse<PagedResult<WorkspaceViewModel>>> GetPaged(BasePagedRequest request);
        Task<ActionResponse> Update(WorkspaceUpdateRequest request);
        Task<ActionResponse> Delete(BaseWriteRequest<Guid> request);
    }
}
