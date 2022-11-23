using Core.Enums;
using Core.Models.ViewModels.Base;
using Workspaces.Core.Enums;

namespace Workspaces.Core.Models.ViewModels.Workspace
{
    public class WorkspaceViewModel : IBaseViewModel<Guid>
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string DisplayName { get; set; }
        public VisibilityEnum Visibility { get; set; }

        public Guid EntityId => Id;
        public EntityType EntityType => EntityType.Workspace;
        public string DisplayValue => DisplayName;
    }
}
