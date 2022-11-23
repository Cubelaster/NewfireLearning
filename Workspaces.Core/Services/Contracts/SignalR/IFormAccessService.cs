using Core.Models.Requests.SignalR;

namespace Workspaces.Core.Services.Contracts.SignalR;

public interface IFormAccessService
{
    Task AddConnection(string connectionId);
    Task DeleteConnection(string connectionId);

    Task EnterForm(FormAccessState request);
    Task ExitForm(FormAccessState request);
    Task ExitAllForms(string connectionId);
}
