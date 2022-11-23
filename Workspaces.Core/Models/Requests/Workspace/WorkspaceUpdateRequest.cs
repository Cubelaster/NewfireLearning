using Core.Models.Requests.Base;

namespace Workspaces.Core.Models.Requests.Workspace
{
    public class WorkspaceUpdateRequest : WorkspaceCreateRequest, IBaseUpdateRequest<Guid>
    {
        public Guid? Id { get; set; }
    }
}
