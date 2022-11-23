using Core.Models.Requests.Filtering.Base;
using Workspaces.Core.Enums;

namespace Workspaces.Core.Models.Requests.Workspace
{
    internal class WorkspaceFilterRequest : BaseFilterRequest
    {
        public string DisplayName { get; set; }
        public VisibilityEnum? VisibilityEnum { get; set; }
    }
}
