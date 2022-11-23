using Core.Enums;
using Core.Models.Requests.SignalR;
using Core.Models.Responses.SignalR;
using Microsoft.AspNetCore.SignalR;
using ReActionResponse.Core;
using Workspaces.Core.Services.Contracts.SignalR;

namespace Workspaces.Application.SignalR;

internal class ChangeNotifierService : IChangeNotifierService
{
    private readonly IHubContext<ChangeNotifierHub> hubContext;

    public ChangeNotifierService(IHubContext<ChangeNotifierHub> hubContext)
    {
        this.hubContext = hubContext;
    }

    public async Task NotifyUserStatusChanged(Guid userId, bool isActive)
    {
        await hubContext.Clients.All.SendAsync(nameof(NotifyUserStatusChanged), new { userId, isActive });
    }

    public async Task SendEntitiesChanged(EntityType entityType)
    {
        await hubContext.Clients.All.SendAsync(nameof(SendEntitiesChanged), entityType);
    }

    public async Task SendEntityChanged<T>(EntityType entityType, T id) where T : struct
    {
        await hubContext.Clients.All.SendAsync(nameof(SendEntityChanged), new SignalREntityResponse<T>
        {
            Id = id,
            EntityType = entityType,
        });
    }

    public async Task SendEntityDeleted<T>(EntityType entityType, T id) where T : struct
    {
        await hubContext.Clients.All.SendAsync(nameof(SendEntityDeleted), new SignalREntityResponse<T>
        {
            Id = id,
            EntityType = entityType,
        });
    }

    public Task SendMessage<T>(ActionResponse<T> actionResponse)
    {
        throw new NotImplementedException();
    }

    public async Task UpdateFormAccessState(List<FormAccessState> newState)
    {
        await hubContext.Clients.All.SendAsync(nameof(UpdateFormAccessState), newState);
    }
}

