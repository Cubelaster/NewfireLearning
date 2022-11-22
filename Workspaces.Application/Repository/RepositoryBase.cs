using System.Linq.Expressions;
using Core.Models.EfModels.Base;
using Core.Repository.Base;
using Core.Repository.Utility;
using Microsoft.EntityFrameworkCore;

namespace Workspaces.Application.Repository;

public class RepositoryBase<T, U> : IRepositoryBase<T, U> where U : struct where T : DatabaseEntity<U>
{
    private readonly DbContext context;

    public RepositoryBase(DbContext context)
    {
        this.context = context;
    }

    public virtual IQueryable<T> GetAll(Expression<Func<T, bool>> filter = null,
        Func<IQueryable<T>, IOrderedEnumerable<T>> orderBy = null,
        string includeProperties = "")
    {
        IQueryable<T> query = context.Set<T>();

        if (filter != null)
        {
            query = query.Where(filter);
        }

        foreach (string includeProperty in includeProperties.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
        {
            query = query.Include(includeProperty.Trim());
        }

        if (orderBy != null)
        {
            return orderBy(query).AsQueryable();
        }

        return query;
    }

    public virtual IQueryable<T> GetActive(Expression<Func<T, bool>> filter = null,
        Func<IQueryable<T>, IOrderedEnumerable<T>> orderBy = null,
        string includeProperties = "")
    {
        IQueryable<T> query = context.Set<T>()
            .Where(q => !q.IsDeleted);

        if (filter != null)
        {
            query = query.Where(filter);
        }

        foreach (string includeProperty in includeProperties.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
        {
            query = query.Include(includeProperty.Trim());
        }

        if (orderBy != null)
        {
            return orderBy(query).AsQueryable();
        }

        return query;
    }

    public virtual IQueryable<T> ReadAll(Expression<Func<T, bool>> filter = null,
        Func<IQueryable<T>, IOrderedEnumerable<T>> orderBy = null)
    {
        IQueryable<T> query = context.Set<T>().AsNoTracking();

        if (filter != null)
        {
            query = query.Where(filter);
        }

        if (orderBy != null)
        {
            return orderBy(query).AsQueryable();
        }

        return query;
    }

    public virtual IQueryable<T> ReadActive(Expression<Func<T, bool>> filter = null, QueryBuildingOptions options = null)
    {
        var query = context.Set<T>()
            .Where(e => !e.IsDeleted)
            .AsNoTracking();

        if (filter != null)
        {
            query = query.Where(filter);
        }

        if (options != null)
        {
            query = HandleQueryBuildingOptions(query, options);
        }

        return query;
    }

    public virtual T FindSingle(Guid id)
    {
        return context.Set<T>().Find(id);
    }

    public virtual T FindSingle(int id)
    {
        return context.Set<T>().Find(id);
    }

    public virtual T FindBy(Expression<Func<T, bool>> predicate, string includeProperties = "")
    {
        IQueryable<T> query = context.Set<T>();
        foreach (string includeProperty in includeProperties.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
        {
            query = query.Include(includeProperty.Trim());
        }
        return query.Where(predicate).FirstOrDefault();
    }

    public virtual void Add(T toAdd)
    {
        context.Set<T>().Add(toAdd);
    }

    public virtual void AddIdentityInsertOn(T toAdd)
    {
        var entityType = context.Model.FindEntityType(typeof(T));
        var schemaName = entityType.GetSchema() ?? "dbo";
        var tableName = entityType.GetTableName();

        context.Database.OpenConnection();
        context.Database.ExecuteSqlRaw($"SET IDENTITY_INSERT {schemaName}.{tableName} ON;");

        context.Set<T>().Add(toAdd);
        context.SaveChanges();

        context.Database.ExecuteSqlRaw($"SET IDENTITY_INSERT {schemaName}.{tableName} OFF;");
        context.Database.CloseConnection();
    }

    public virtual void AddRange(List<T> toAdd)
    {
        context.Set<T>().AddRange(toAdd);
    }

    public virtual void Update(T toUpdate)
    {
        context.Set<T>().Update(toUpdate);
    }

    public virtual void Delete(Guid id)
    {
        T entity = FindSingle(id);
        context.Set<T>().Remove(entity);
    }

    public virtual void Delete(T entity)
    {
        context.Set<T>().Remove(entity);
    }

    public void Delete(int id)
    {
        T entity = FindSingle(id);
        context.Set<T>().Remove(entity);
    }

    public T FindSingle(U id)
    {
        return context.Set<T>().Find(id);
    }

    public void Delete(U id)
    {
        T entity = FindSingle(id);
        context.Set<T>().Remove(entity);
    }

    public void DeleteBulk(IEnumerable<U> ids)
    {
        var entitiesToDelete = GetActive(e => ids.Contains(e.Id));
        context.Set<T>().RemoveRange(entitiesToDelete);
    }

    public void DeleteBulk(IEnumerable<T> entitiesToDelete)
    {
        context.Set<T>().RemoveRange(entitiesToDelete);
    }

    private IQueryable<T> HandleQueryBuildingOptions<T>(IQueryable<T> query, QueryBuildingOptions options) where T : DatabaseEntity
    {
        if (options.AsSplitQuery)
        {
            query = query.AsSplitQuery();
        }

        return query;
    }
}