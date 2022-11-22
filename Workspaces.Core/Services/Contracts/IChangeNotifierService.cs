using Core.Enums;
using Core.Models.Requests.SignalR;
using ReActionResponse.Core;

namespace Workspaces.Core.Services.Contracts;

public interface IChangeNotifierService
{
    Task SendMessage<T>(ActionResponse<T> actionResponse);
    Task SendEntityChanged<T>(EntityType entityType, T id) where T : struct;
    Task SendEntityDeleted<T>(EntityType entityType, T id) where T : struct;
    Task SendEntitiesChanged(EntityType entityType);
    Task UpdateFormAccessState(List<FormAccessState> newState);
    Task NotifyUserStatusChanged(Guid userId, bool isActive);
}
