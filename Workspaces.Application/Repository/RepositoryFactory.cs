using Core.Models.EfModels.Base;
using Microsoft.EntityFrameworkCore;

namespace Workspaces.Application.Repository;

internal class RepositoryFactory
{
    private readonly IDictionary<Type, Func<DbContext, object>> _factoryCache;

    public RepositoryFactory()
    {
        _factoryCache = GetFactories();
    }

    public Func<DbContext, object> GetRepositoryFactoryForEntityType<T, U>() where U : struct where T : DatabaseEntity<U>
    {
        Func<DbContext, object> factory = GetRepositoryFactoryFromCache<T>();
        if (factory != null)
        {
            return factory;
        }

        return DefaultEntityRepositoryFactory<T, U>();
    }

    public Func<DbContext, object> GetRepositoryFactoryFromCache<T>()
    {
        _factoryCache.TryGetValue(typeof(T), out Func<DbContext, object> factory);
        return factory;
    }

    private IDictionary<Type, Func<DbContext, object>> GetFactories()
    {
        Dictionary<Type, Func<DbContext, object>> dic = new Dictionary<Type, Func<DbContext, object>>
        {
            //{ typeof(IUserRepository), context => new UserRepository((AppDbContext)context) }
        };
        //Add Extended and Custom Repositories here
        return dic;
    }

    private Func<DbContext, object> DefaultEntityRepositoryFactory<T, U>() where U : struct where T : DatabaseEntity<U>
    {
        return dbContext => new RepositoryBase<T, U>(dbContext);
    }
}
