using System.Security.Claims;

namespace Workspaces.Core.Services.Contracts;

public interface IHttpContextService
{
    Guid? CurrentUserId { get; }
    ClaimsPrincipal CurrentUser { get; }
}
