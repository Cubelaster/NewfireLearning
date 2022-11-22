using Core.Models.EfModels.Base;
using Core.Repository.Base;
using Microsoft.EntityFrameworkCore;
using Workspaces.Infrastructure.Repository.Base;

namespace Workspaces.Application.Repository;

internal class RepositoryProvider : IRepositoryProvider
{
    public DbContext DbContext { get; set; }

    private readonly RepositoryFactory _factory;

    protected Dictionary<Type, object> Repositories { get; private set; }

    public RepositoryProvider()
    {
        _factory = new RepositoryFactory();
        Repositories = new Dictionary<Type, object>();
    }

    public IRepositoryBase<T, U> GetGenericRepository<T, U>() where U : struct where T : DatabaseEntity<U>
    {
        Func<DbContext, object> repositoryFactoryForEntityTypeDelegate = _factory.GetRepositoryFactoryForEntityType<T, U>();
        return GetCustomRepository<IRepositoryBase<T, U>>(repositoryFactoryForEntityTypeDelegate);
    }

    public virtual T GetCustomRepository<T>(Func<DbContext, object> factory = null) where T : class
    {
        Repositories.TryGetValue(typeof(T), out object repository);

        if (repository != null)
        {
            return (T)repository;
        }

        return CreateRepository<T>(factory, DbContext);
    }

    private T CreateRepository<T>(Func<DbContext, object> factory, DbContext dbContext)
    {
        Func<DbContext, object> repositoryFactory;
        if (factory != null)
        {
            repositoryFactory = factory;
        }
        else
        {
            repositoryFactory = _factory.GetRepositoryFactoryFromCache<T>();
        }

        if (repositoryFactory == null)
        {
            throw new NotSupportedException(typeof(T).FullName);
        }

        T repository = (T)repositoryFactory(dbContext);
        Repositories[typeof(T)] = repository;

        return repository;
    }
}
