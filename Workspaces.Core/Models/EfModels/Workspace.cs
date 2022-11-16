using Core.Models.EfModels.Base;
using Workspaces.Core.Enums;

namespace Workspaces.Core.Models.EfModels
{
    public class Workspace : DatabaseEntity<Guid>
    {
        public string DisplayName { get; set; }
        public VisibilityEnum Visibility { get; set; }
    }
}
