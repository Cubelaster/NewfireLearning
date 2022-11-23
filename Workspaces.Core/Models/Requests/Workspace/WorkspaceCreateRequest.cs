using Core.Models.Requests.Base;
using Workspaces.Core.Enums;

namespace Workspaces.Core.Models.Requests.Workspace
{
    public class WorkspaceCreateRequest : BaseRequest
    {
        public string DisplayName { get; set; }
        public VisibilityEnum Visibility { get; set; }
    }
}
