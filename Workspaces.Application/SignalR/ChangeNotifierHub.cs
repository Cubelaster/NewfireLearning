using Core.Enums;
using Core.Models.Requests.SignalR;
using Microsoft.AspNetCore.SignalR;
using Workspaces.Core.Services.Contracts.SignalR;

namespace Workspaces.Application.SignalR;

public class ChangeNotifierHub : Hub
{
    private readonly IFormAccessService formAccessService;

    public ChangeNotifierHub(IFormAccessService formAccessService)
    {
        this.formAccessService = formAccessService;
    }

    //public override Task OnConnectedAsync()
    //{
    //    formAccessService.AddConnection(Context.ConnectionId);

    //    return base.OnConnectedAsync();
    //}

    public override Task OnDisconnectedAsync(Exception exception)
    {
        formAccessService.DeleteConnection(Context.ConnectionId);

        return base.OnDisconnectedAsync(exception);
    }

    public Task EnterForm(FormAccessStateUpdateRequest request)
    {
        var realRequest = new FormAccessState
        {
            EntityId = request.EntityId,
            EntityType = (EntityType)request.EntityType,
            AdditionalData = request.AdditionalData,
            ConnectionId = Context.ConnectionId
        };
        return formAccessService.EnterForm(realRequest);
    }

    public Task ExitForm(FormAccessStateUpdateRequest request)
    {
        var realRequest = new FormAccessState
        {
            EntityId = request.EntityId,
            EntityType = (EntityType)request.EntityType,
            AdditionalData = request.AdditionalData,
            ConnectionId = Context.ConnectionId
        };
        return formAccessService.ExitForm(realRequest);
    }

    public Task ExitAllForms()
    {
        return formAccessService.ExitAllForms(Context.ConnectionId);
    }
}
