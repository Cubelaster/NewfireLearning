using Core.Models.EfModels.Base;
using Core.Repository.Base;
using Microsoft.EntityFrameworkCore;

namespace Workspaces.Infrastructure.Repository.UnitOfWork;

public interface IUnitOfWork : IDisposable
{
    IRepositoryBase<T, U> GetGenericRepository<T, U>() where U : struct where T : DatabaseEntity<U>;

    T GetCustomRepository<T>() where T : class;

    // Unlike GetGenericRepository, this one is used for entities not based on DatabaseEntity
    DbSet<T> GetDbSet<T>() where T : class;

    int Save(int? applicationActionId = null);

    Task<int> SaveAsync(int? applicationActionId = null);

    void ClearChangeTracker();
}
