using Core.Models.EfModels.Base;
using Core.Repository.Base;
using Microsoft.EntityFrameworkCore;

namespace Workspaces.Infrastructure.Repository.Base;

public interface IRepositoryProvider
{
    DbContext DbContext { get; set; }

    IRepositoryBase<T, U> GetGenericRepository<T, U>() where U : struct where T : DatabaseEntity<U>;

    T GetCustomRepository<T>(Func<DbContext, object> factory = null) where T : class;
}
