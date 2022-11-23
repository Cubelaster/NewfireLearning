using System.Text;
using Core.Models.Dtos.SignalR;
using Core.Models.Requests.SignalR;
using Core.Resources;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Localization;
using Workspaces.Core.Services.Contracts.SignalR;
using Workspaces.Core.Services.Contracts.Utility;

namespace Workspaces.Application.SignalR;

//TODO UserId and Authorization need to be implemented
internal class FormAccessService : IFormAccessService
{
    private readonly ConnectionMapping connections = new();
    private readonly List<FormAccessState> formAccessState;

    private readonly IHttpContextService httpContextService;
    private readonly IChangeNotifierService changeNotifierService;
    private readonly IAppLogger logger;
    private readonly IStringLocalizer<Resources> stringLocalizer;
    private readonly IMemoryCache memoryCache;

    public FormAccessService(
        IHttpContextService httpContextService,
        IChangeNotifierService changeNotifierService,
        IMemoryCache memoryCache,
        IAppLogger logger,
        IStringLocalizer<Resources> stringLocalizer)
    {
        this.httpContextService = httpContextService;
        this.changeNotifierService = changeNotifierService;
        this.logger = logger;
        this.stringLocalizer = stringLocalizer;
        this.memoryCache = memoryCache;

        if (!this.memoryCache.TryGetValue(nameof(formAccessState), out formAccessState))
        {
            this.memoryCache.Set(nameof(formAccessState), formAccessState ?? new());
        }
    }

    public Task AddConnection(string connectionId)
    {
        try
        {
            if (httpContextService.CurrentUserId.HasValue)
            {
                connections.Add(httpContextService.CurrentUserId.ToString(), connectionId);
            }

            return Task.CompletedTask;
        }
        catch (Exception ex)
        {
            logger.LogError(stringLocalizer.GetString(Resources.DeleteError), ex, connectionId);
            return Task.CompletedTask;
        }
    }

    public async Task DeleteConnection(string connectionId)
    {
        try
        {
            // F5 on FE kills userId since SignalR attaches before Token resolve
            //if ((await userService.GetCurrentUserBase())
            //    .IsSuccessAndHasData(out UserBaseViewModel user))
            //{
            //    connections.Remove(user.Id.ToString(), connectionId);
            //}
            //else
            //{
            //    connections.RemoveConnection(connectionId);
            //}

            await ExitAllForms(connectionId);
        }
        catch (Exception ex)
        {
            logger.LogError(stringLocalizer.GetString(Resources.ErrorInSignalR), ex, connectionId);
        }
    }

    public async Task EnterForm(FormAccessState request)
    {
        try
        {
            //var user = (await userService.GetCurrentUserBase()).Data;

            //request.UserId = user?.Id.ToString();
            FormAccessState targetFormAccessState = null;

            if (request.AdditionalData == null)
            {
                targetFormAccessState = formAccessState
                    .FirstOrDefault(e => e.EntityType == request.EntityType && e.EntityId == request.EntityId);
            }
            else
            {
                // Having additional data means we're tracking it globally for some specific reason
                var targetFormAccessStates = formAccessState
                    .Where(e => e.EntityType == request.EntityType
                        && e.EntityId == request.EntityId
                        && e.AdditionalData != null)
                    .ToList();

                if (targetFormAccessStates.Count > 0)
                {
                    // The comparison here is by string value 
                    // Because it's a Json object under it, or basically string
                    // Since it's coming from web
                    targetFormAccessState = targetFormAccessStates
                        .FirstOrDefault(e => request.AdditionalData.ToString() == e.AdditionalData.ToString());
                }
            }

            if (targetFormAccessState != null)
            {
                if (request.EntityId != null)
                {
                    // we don't allow the user to open 2 of the same tabs for an Entity
                }
                else
                {
                    // However, the user can open any number of New instances
                    targetFormAccessState.Instances++;
                }
            }
            else
            {
                request.Instances = 1;
                formAccessState.Add(request);
            }

            memoryCache.Set(nameof(formAccessState), formAccessState);

            await changeNotifierService.UpdateFormAccessState(formAccessState);
        }
        catch (Exception ex)
        {
            logger.LogError(stringLocalizer.GetString(Resources.ErrorInSignalR), ex, request);
        }
    }

    public async Task ExitAllForms(string connectionId)
    {
        try
        {
            formAccessState.Where(e => e.ConnectionId == connectionId)
                .ToList().ForEach(e => formAccessState.Remove(e));

            memoryCache.Set(nameof(formAccessState), formAccessState);

            await changeNotifierService.UpdateFormAccessState(formAccessState);
        }
        catch (Exception ex)
        {
            logger.LogError(stringLocalizer.GetString(Resources.ErrorInSignalR), ex, connectionId);
        }
    }

    public async Task ExitForm(FormAccessState request)
    {
        try
        {
            //var user = (await userService.GetCurrentUserBase()).Data;

            //request.UserId = user?.Id.ToString();
            var targetFormAccessState = formAccessState
                .FirstOrDefault(e => e.EntityType == request.EntityType
                    && e.EntityId == request.EntityId);

            if (targetFormAccessState != null)
            {
                if (request.EntityId != null)
                {
                    // we don't allow the user to open 2 of the same tabs for an Entity
                    formAccessState.Remove(targetFormAccessState);
                }
                else
                {
                    // However, the user can open any number of New instances
                    targetFormAccessState.Instances--;
                    if (targetFormAccessState.Instances == 0)
                    {
                        formAccessState.Remove(targetFormAccessState);
                    }
                }
            }

            memoryCache.Set(nameof(formAccessState), formAccessState);

            await changeNotifierService.UpdateFormAccessState(formAccessState);
        }
        catch (Exception ex)
        {
            logger.LogError(stringLocalizer.GetString(Resources.ErrorInSignalR), ex, request);
        }
    }
}
