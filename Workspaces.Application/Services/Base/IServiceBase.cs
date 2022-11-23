using System.Linq.Expressions;
using AutoMapper;
using Core.Enums;
using Core.Models.EfModels.Base;
using Core.Models.Requests.Base;
using Core.Models.ViewModels.Base;
using Core.Repository.Utility;
using Core.Resources;
using Microsoft.Extensions.Localization;
using ReActionResponse.Core;
using ReFilter.Models;
using ReFilter.ReFilterActions;
using Workspaces.Core.Services.Contracts.Utility;
using Workspaces.Infrastructure.Repository.UnitOfWork;

namespace Workspaces.Application.Services.Base;

public interface IServiceBase
{
    IUnitOfWork UnitOfWork { get; }
    IMapper Mapper { get; }
    IStringLocalizer<Resources> StringLocalizer { get; }
    IAppLogger Logger { get; }
    IReFilterActions ReFilterActions { get; }
    public EntityType EntityType { get; set; }
    Func<DatabaseEntity, ActionResponse> ValidateFunction { get; set; }
    Func<BaseRequest, ActionResponse> DeleteCheckFunction { get; set; }

    Task<ActionResponse> Delete<T, U>(BaseWriteRequest<U> request) where U : struct where T : DatabaseEntity<U>;
    Task<ActionResponse> DeleteBulk<T, U>(IEnumerable<U> request) where T : DatabaseEntity<U> where U : struct;
    Task<ActionResponse> DeleteBulk<T, U>(IEnumerable<T> request) where T : DatabaseEntity<U> where U : struct;
    Task<ActionResponse<U>> Create<T, U>(BaseRequest request) where U : struct where T : DatabaseEntity<U>;
    Task<ActionResponse> CreateBulk<T, U>(IEnumerable<BaseRequest> request) where T : DatabaseEntity<U> where U : struct;
    Task<ActionResponse> Update<T, U>(IBaseUpdateRequest<U> request) where U : struct where T : DatabaseEntity<U>;
    Task<ActionResponse> UpdateBulk<T, U>(IEnumerable<IBaseUpdateRequest<U>> request) where T : DatabaseEntity<U> where U : struct;
    Task<ActionResponse<V>> Get<V, T, U>(U id, QueryBuildingOptions options = null) where U : struct where T : DatabaseEntity<U> where V : IBaseViewModel<U>;
    Task<ActionResponse<List<V>>> GetAll<V, T, U>(QueryBuildingOptions options = null) where U : struct where T : DatabaseEntity<U> where V : IBaseViewModel<U>;
    Task<ActionResponse<PagedResult<V>>> GetPaged<V, U, T>(BasePagedRequest request, QueryBuildingOptions options = null) where V : class, IBaseViewModel<T>, new() where U : DatabaseEntity<T>, new() where T : struct;
    Task<ActionResponse<PagedResult<V>>> GetFiltered<V, U, T>(BasePagedRequest request, QueryBuildingOptions options = null) where V : class, IBaseViewModel<T>, new() where U : DatabaseEntity<T>, new() where T : struct;
    Task<ActionResponse<List<V>>> GetWithFilter<V, U, T>(Expression<Func<U, bool>> filter = null, QueryBuildingOptions options = null) where V : class, IBaseViewModel<T>, new() where U : DatabaseEntity<T>, new() where T : struct;

    Task NotifyHubEntitiesChanged<T, U>(EntityType? entityType = null) where T : DatabaseEntity<U> where U : struct;
    Task NotifyHubEntityChanged<T, U>(U id, EntityType? entityType = null) where T : DatabaseEntity<U> where U : struct;
    Task NotifyHubEntityDeleted<T, U>(U id, EntityType? entityType = null) where T : DatabaseEntity<U> where U : struct;

    ActionResponse Validate<T, U>(T entity) where T : DatabaseEntity<U> where U : struct;
    ActionResponse DeleteCheck<T, U>(BaseWriteRequest<U> id) where T : DatabaseEntity<U> where U : struct;
}
