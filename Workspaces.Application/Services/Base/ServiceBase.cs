using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using AutoMapper;
using Core.Enums;
using Core.Models.EfModels.Base;
using Core.Models.Requests.Base;
using Core.Models.ViewModels.Base;
using Core.Repository.Utility;
using Core.Resources;
using Core.Services.Contracts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Localization;
using ReActionResponse.Core;
using ReActionResponse.Core.Extensions;
using ReFilter.Models;
using ReFilter.ReFilterActions;
using Workspaces.Application.Utility;
using Workspaces.Core.Services.Base;
using Workspaces.Core.Services.Contracts;
using Workspaces.Infrastructure.Repository.UnitOfWork;

namespace Application.Services.Base
{
    public class ServiceBase : IServiceBase
    {
        #region Ctors and Members

        public IUnitOfWork UnitOfWork { get; }
        public IMapper Mapper { get; }
        public IStringLocalizer<Resources> StringLocalizer { get; }
        public IAppLogger Logger { get; }
        public IReFilterActions ReFilterActions { get; }
        public IChangeNotifierService ChangeNotifierService { get; }
        public IValidationService ValidationService { get; }
        public EntityType EntityType { get; set; } = EntityType.Undefined;
        public Func<DatabaseEntity, ActionResponse> ValidateFunction { get; set; }
        public Func<BaseRequest, ActionResponse> DeleteCheckFunction { get; set; }

        public ServiceBase(IUnitOfWork unitOfWork,
            IMapper mapper,
            IStringLocalizer<Resources> stringLocalizer,
            IAppLogger logger,
            IReFilterActions reFilterActions,
            IChangeNotifierService changeNotifierService,
            IValidationService validationService)
        {
            Mapper = mapper;
            UnitOfWork = unitOfWork;
            StringLocalizer = stringLocalizer;
            Logger = logger;
            ReFilterActions = reFilterActions;
            ChangeNotifierService = changeNotifierService;
            ValidationService = validationService;
        }

        #endregion Ctors and Members

        public async Task<ActionResponse<U>> Create<T, U>(BaseRequest request)
            where T : DatabaseEntity<U>
            where U : struct
        {
            try
            {
                var entityToInsert = Mapper.Map<T>(request);

                if (Validate<T, U>(entityToInsert).IsError(out ActionResponse validationResponse))
                {
                    return validationResponse.Convert<U>();
                }

                UnitOfWork.GetGenericRepository<T, U>().Add(entityToInsert);
                await UnitOfWork.SaveAsync(request.ApplicationActionId);

                await NotifyHubEntitiesChanged<T, U>();

                var response = ActionResponse<U>.Success(entityToInsert.Id
                    , StringLocalizer.GetString(Resources.InsertSuccess))
                        .Merge(validationResponse);

                return response;
            }
            catch (Exception ex)
            {
                return Logger.LogError(StringLocalizer.GetString(Resources.InsertError), ex, request).Convert<U>();
            }
        }

        public async Task<ActionResponse> CreateBulk<T, U>(IEnumerable<BaseRequest> request)
            where T : DatabaseEntity<U>
            where U : struct
        {
            try
            {
                var entitiesToInsert = Mapper.Map<List<T>>(request);
                UnitOfWork.GetGenericRepository<T, U>().AddRange(entitiesToInsert);
                await UnitOfWork.SaveAsync(request.FirstOrDefault()?.ApplicationActionId);

                return ActionResponse.Success(Message: StringLocalizer.GetString(Resources.InsertSuccess));
            }
            catch (Exception ex)
            {
                return Logger.LogError(StringLocalizer.GetString(Resources.InsertError), ex, request);
            }
        }

        public async Task<ActionResponse> Delete<T, U>(BaseWriteRequest<U> request)
            where T : DatabaseEntity<U>
            where U : struct
        {
            try
            {
                if (DeleteCheck<T, U>(request).IsNotSuccess(out ActionResponse response))
                {
                    return response;
                }

                UnitOfWork.GetGenericRepository<T, U>().Delete(request.Id.Value);
                await UnitOfWork.SaveAsync(request.ApplicationActionId);

                await NotifyHubEntitiesChanged<T, U>();

                return ActionResponse.Success(Message: StringLocalizer.GetString(Resources.DeleteSuccess));
            }
            catch (Exception ex)
            {
                return Logger.LogError(StringLocalizer.GetString(Resources.DeleteError), ex, request);
            }
        }

        public async Task<ActionResponse> DeleteBulk<T, U>(IEnumerable<U> request)
            where T : DatabaseEntity<U>
            where U : struct
        {
            try
            {
                UnitOfWork.GetGenericRepository<T, U>().DeleteBulk(request);
                await UnitOfWork.SaveAsync();

                return ActionResponse.Success(Message: StringLocalizer.GetString(Resources.DeleteSuccess));
            }
            catch (Exception ex)
            {
                return Logger.LogError(StringLocalizer.GetString(Resources.DeleteError), ex, request);
            }
        }

        public async Task<ActionResponse> DeleteBulk<T, U>(IEnumerable<T> request)
            where T : DatabaseEntity<U>
            where U : struct
        {
            try
            {
                UnitOfWork.GetGenericRepository<T, U>().DeleteBulk(request);
                await UnitOfWork.SaveAsync();

                return ActionResponse.Success(Message: StringLocalizer.GetString(Resources.DeleteSuccess));
            }
            catch (Exception ex)
            {
                return Logger.LogError(StringLocalizer.GetString(Resources.InsertError), ex, request);
            }
        }

        public Task<ActionResponse<V>> Get<V, T, U>(U id, QueryBuildingOptions options = null)
            where V : IBaseViewModel<U>
            where T : DatabaseEntity<U>
            where U : struct
        {
            try
            {
                var query = UnitOfWork.GetGenericRepository<T, U>()
                    .ReadActive(e => e.Id.Equals(id), options);

                var result = Mapper.ProjectTo<V>(query).FirstOrDefault();

                return Task.FromResult(ActionResponse<V>.Success(result));
            }
            catch (Exception ex)
            {
                return Task.FromResult(Logger.LogError(StringLocalizer.GetString(Resources.FetchError), ex, id).Convert<V>());
            }
        }

        public async Task<ActionResponse<List<V>>> GetAll<V, T, U>(QueryBuildingOptions options = null)
            where V : IBaseViewModel<U>
            where T : DatabaseEntity<U>
            where U : struct
        {
            try
            {
                var query = UnitOfWork.GetGenericRepository<T, U>()
                .ReadActive(options: options);

                var result = await Mapper.ProjectTo<V>(query).ToListAsync();

                return ActionResponse<List<V>>.Success(result);
            }
            catch (Exception ex)
            {
                return Logger.LogError(StringLocalizer.GetString(Resources.FetchError), ex, null).Convert<List<V>>();
            }
        }

        public async Task<ActionResponse> Update<T, U>(IBaseUpdateRequest<U> request)
            where T : DatabaseEntity<U>
            where U : struct
        {
            try
            {
                var entityToUpdate = UnitOfWork.GetGenericRepository<T, U>().FindSingle(request.Id.Value);

                Mapper.Map(request, entityToUpdate);

                if (Validate<T, U>(entityToUpdate).IsError(out ActionResponse validationResponse))
                {
                    return validationResponse.Convert<U>();
                }

                await UnitOfWork.SaveAsync(Unsafe.As<BaseRequest>(request).ApplicationActionId);

                await NotifyHubEntityChanged<T, U>(request.Id.Value);

                var response = ActionResponse.Success(Message: StringLocalizer.GetString(Resources.UpdateSuccess), Code: 204)
                        .Merge(validationResponse);

                return response;
            }
            catch (Exception ex)
            {
                return Logger.LogError(StringLocalizer.GetString(Resources.UpdateError), ex, request);
            }
        }

        public async Task<ActionResponse> UpdateBulk<T, U>(IEnumerable<IBaseUpdateRequest<U>> request)
            where T : DatabaseEntity<U>
            where U : struct
        {
            try
            {
                var entitiesToUpdate = UnitOfWork.GetGenericRepository<T, U>().GetAll(e => request.Select(r => r.Id).Contains(e.Id));

                foreach (var entity in entitiesToUpdate)
                {
                    var requestEntity = request.FirstOrDefault(r => r.Id.Value.Equals(entity.Id));
                    Mapper.Map(requestEntity, entity);
                }

                await UnitOfWork.SaveAsync();

                return ActionResponse.Success(Message: StringLocalizer.GetString(Resources.UpdateSuccess), Code: 204);
            }
            catch (Exception ex)
            {
                return Logger.LogError(StringLocalizer.GetString(Resources.UpdateError), ex, request);
            }
        }

        public async Task<ActionResponse<PagedResult<V>>> GetPaged<V, U, T>(BasePagedRequest request, QueryBuildingOptions options = null) where V : class, IBaseViewModel<T>, new() where U : DatabaseEntity<T>, new() where T : struct
        {
            try
            {
                var query = UnitOfWork.GetGenericRepository<U, T>()
                    .ReadActive(options: options);

                var pagedRequest = request.GetPagedRequest((IQueryable<U> x) => Mapper.ProjectTo<V>(x).ToList());
                var pagedResult = await ReFilterActions.GetPaged(query, pagedRequest);

                return ActionResponse<PagedResult<V>>.Success(pagedResult);
            }
            catch (Exception ex)
            {
                return Logger.LogError(StringLocalizer.GetString(Resources.FetchError), ex, request).Convert<PagedResult<V>>();
            }
        }

        public async Task<ActionResponse<PagedResult<V>>> GetFiltered<V, U, T>(BasePagedRequest request, QueryBuildingOptions options = null) where V : class, IBaseViewModel<T>, new() where U : DatabaseEntity<T>, new() where T : struct
        {
            try
            {
                var query = UnitOfWork.GetGenericRepository<U, T>()
                    .ReadActive(options: options);

                var pagedRequest = request.GetPagedRequest((IQueryable<U> x) => Mapper.ProjectTo<V>(x).ToList());
                var pagedResult = await ReFilterActions.GetFiltered(query, pagedRequest);

                return ActionResponse<PagedResult<V>>.Success(pagedResult);
            }
            catch (Exception ex)
            {
                return Logger.LogError(StringLocalizer.GetString(Resources.FetchError), ex, request).Convert<PagedResult<V>>();
            }
        }

        public async Task<ActionResponse<List<V>>> GetWithFilter<V, U, T>(Expression<Func<U, bool>> filter, QueryBuildingOptions options = null) where V : class, IBaseViewModel<T>, new() where U : DatabaseEntity<T>, new() where T : struct
        {
            try
            {
                var query = UnitOfWork.GetGenericRepository<U, T>()
                    .ReadActive(filter, options);

                var result = await Mapper.ProjectTo<V>(query).ToListAsync();

                return ActionResponse<List<V>>.Success(result);
            }
            catch (Exception ex)
            {
                return Logger.LogError(StringLocalizer.GetString(Resources.FetchError), ex, null).Convert<List<V>>();
            }
        }

        #region Maybe Remove

        public async Task NotifyHubEntitiesChanged<T, U>(EntityType? entityType = null)
            where T : DatabaseEntity<U>
            where U : struct
        {
            var realEntityType = !entityType.HasValue && EntityType != EntityType.Undefined
                ? EntityType : EntityTypeMatcher.GetEntityTypeConfig<T>().EntityType;
            await ChangeNotifierService.SendEntitiesChanged(realEntityType);
        }

        public async Task NotifyHubEntityChanged<T, U>(U id, EntityType? entityType = null)
            where T : DatabaseEntity<U>
            where U : struct
        {
            var realEntityType = !entityType.HasValue && EntityType != EntityType.Undefined
                ? EntityType : EntityTypeMatcher.GetEntityTypeConfig<T>().EntityType;
            await ChangeNotifierService.SendEntityChanged(realEntityType, id);
        }

        public async Task NotifyHubEntityDeleted<T, U>(U id, EntityType? entityType = null)
            where T : DatabaseEntity<U>
            where U : struct
        {
            var realEntityType = !entityType.HasValue && EntityType != EntityType.Undefined
                ? EntityType : EntityTypeMatcher.GetEntityTypeConfig<T>().EntityType;
            await ChangeNotifierService.SendEntityChanged(realEntityType, id);
        }

        public ActionResponse Validate<T, U>(T entity)
            where T : DatabaseEntity<U>
            where U : struct
        {

            if (ValidationService.Validate<T, U>(entity).IsError(out ActionResponse validationResponse))
            {
                return validationResponse;
            }

            if (ValidateFunction != null && ValidateFunction(entity).IsError(out validationResponse))
            {
                return validationResponse;
            }

            return validationResponse;
        }

        public ActionResponse DeleteCheck<T, U>(BaseWriteRequest<U> request)
            where T : DatabaseEntity<U>
            where U : struct
        {
            if (DeleteCheckFunction != null)
            {
                return DeleteCheckFunction(request);
            }

            return ActionResponse.Success();
        }

        #endregion Maybe Remove
    }
}
