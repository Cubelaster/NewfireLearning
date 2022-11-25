using Core.Models.Requests.Base;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ReActionResponse.Api;
using ReActionResponse.Core;
using ReFilter.Models;
using Workspaces.Application.Services.Base;
using Workspaces.Core.Models.Requests.Workspace;
using Workspaces.Core.Models.ViewModels.Workspace;
using Workspaces.Core.Services.Contracts;

namespace Workspaces.Api.Controllers
{
    [Authorize]
    [ApiController]
    [ApiVersion("1.0")]
    [Route("api/[controller]/[action]")]
    public class WorkspaceController : ControllerBase
    {
        #region Ctors and Members

        private readonly IWorkspaceService service;

        public WorkspaceController(IWorkspaceService service)
        {
            this.service = service;
        }

        #endregion Ctors and Members

        #region Readers

        [HttpGet]
        [Route("{id}")]
        public async Task<ActionResult<ActionResponse<WorkspaceViewModel>>> Get(Guid id)
        {
            return (await service.Get(id)).FinishAction();
        }

        [HttpPost]
        public async Task<ActionResult<ActionResponse<PagedResult<WorkspaceViewModel>>>> GetPaged(BasePagedRequest request)
        {
            return (await service.GetPaged(request)).FinishAction();
        }

        #endregion Readers

        #region Writers

        [HttpPost]
        public async Task<ActionResult<ActionResponse<Guid>>> Create(WorkspaceCreateRequest request)
        {
            return (await service.Create(request)).FinishAction();
        }

        [HttpPut]
        [Route("{id}")]
        public async Task<ActionResult<ActionResponse>> Update(WorkspaceUpdateRequest request)
        {
            return (await service.Update(request)).FinishAction();
        }

        [HttpDelete]
        [Route("{id}")]
        public async Task<ActionResult<ActionResponse>> Delete(BaseWriteRequest<Guid> request)
        {
            return (await service.Delete(request)).FinishAction();
        }

        #endregion Writers
    }
}
