using AutoMapper;
using Workspaces.Core.Models.EfModels;
using Workspaces.Core.Models.Requests.Workspace;
using Workspaces.Core.Models.ViewModels.Workspace;

namespace Workspaces.Core.AutoMapper
{
    internal class WorkspaceProfile : Profile
    {
        public WorkspaceProfile()
        {
            CreateMap<Workspace, WorkspaceViewModel>();

            CreateMap<WorkspaceCreateRequest, Workspace>();

            CreateMap<WorkspaceUpdateRequest, Workspace>()
                .IncludeBase<WorkspaceCreateRequest, Workspace>();
        }
    }
}
