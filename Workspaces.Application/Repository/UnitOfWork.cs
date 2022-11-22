using Core.Models.EfModels.Base;
using Core.Models.EfModels.Logging;
using Core.Repository.Base;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Newtonsoft.Json;
using Workspaces.Core.Services.Contracts;
using Workspaces.Infrastructure.EfContext;
using Workspaces.Infrastructure.Repository.Base;
using Workspaces.Infrastructure.Repository.UnitOfWork;

namespace Workspaces.Application.Repository;

// https://offering.solutions/blog/articles/2014/07/01/asp-net-mvc-generic-repositories-and-unitofwork/
public class UnitOfWork : IUnitOfWork
{
    private readonly WorkspacesDbContext context;
    private readonly IRepositoryProvider repositoryProvider;
    private readonly IHttpContextService httpContextService;

    public UnitOfWork(WorkspacesDbContext context,
        IHttpContextService httpContextService)
    {
        this.context = context;
        this.httpContextService = httpContextService;

        // TODO
        // Turn this on when you can't handle tracking anymore
        // On second thought, don't touch this. It works fine as it is so don't fuck it up. 
        // I know you, so don't even try it
        // I am warning you
        // Ok, so currently this is set to TRACKING because all of the actions are seperated from each other
        // When and IF it changes, you need to enable this and also Update in ServiceBase
        // this.context.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
        // Update 11.11.2021. => Check the ArticleService.UpdateFull
        // Tracking update works so no reason to set to NoTracking
        // Use NoTracking for Reads and Tracking for Writes

        if (repositoryProvider == null)
        {
            repositoryProvider = new RepositoryProvider();
        }

        repositoryProvider.DbContext = context;
    }

    public int Save(int? applicationActionId)
    {
        var changeTracker = context.ChangeTracker;

        var modifiedEntries = changeTracker.Entries()
          .Where(x => x.Entity.GetType().IsSubclassOf(typeof(DatabaseEntity))
            && x.State != EntityState.Unchanged
            && x.Entity.GetType().Name != nameof(AuditLog))
          .ToList();

        if (applicationActionId.HasValue)
        {
            AddLogs(applicationActionId.Value, modifiedEntries);
        }

        foreach (var entry in modifiedEntries)
        {
            if (entry.Entity is DatabaseEntity entity)
            {
                entity.DateModified = DateTime.UtcNow;
                entity.LastModifiedById = httpContextService.CurrentUserId;
                entry.Property(nameof(DatabaseEntity.DateModified)).IsModified = true;

                if (entry.State == EntityState.Deleted)
                {
                    entry.State = EntityState.Modified;
                    entity.IsDeleted = true;
                    entry.Property(nameof(DatabaseEntity.IsDeleted)).IsModified = true;
                }

                if (entry.State == EntityState.Added)
                {
                    entity.IsDeleted = false;
                    entity.DateCreated = DateTime.UtcNow;
                    entity.CreatedById = httpContextService.CurrentUserId;
                }

                if (entry.State == EntityState.Modified)
                {
                    entry.Property(nameof(DatabaseEntity.DateCreated)).IsModified = false;
                    entry.Property(nameof(DatabaseEntity.CreatedById)).IsModified = false;
                }
            }
        }

        return context.SaveChanges();
    }

    public async Task<int> SaveAsync(int? applicationActionId)
    {
        var changeTracker = context.ChangeTracker;

        var modifiedEntries = changeTracker.Entries()
          .Where(x => x.Entity.GetType().IsSubclassOf(typeof(DatabaseEntity))
            && x.State != EntityState.Unchanged
            && x.Entity.GetType().Name != nameof(AuditLog))
          .ToList();

        if (applicationActionId.HasValue)
        {
            AddLogs(applicationActionId.Value, modifiedEntries);
        }

        foreach (var entry in modifiedEntries)
        {
            if (entry.Entity is DatabaseEntity entity)
            {
                entity.DateModified = DateTime.UtcNow;
                entity.LastModifiedById = httpContextService.CurrentUserId;
                entry.Property(nameof(DatabaseEntity.DateModified)).IsModified = true;

                if (entry.State == EntityState.Deleted)
                {
                    entry.State = EntityState.Modified;
                    entity.IsDeleted = true;
                    entry.Property(nameof(DatabaseEntity.IsDeleted)).IsModified = true;
                }

                if (entry.State == EntityState.Added)
                {
                    entity.IsDeleted = false;
                    entity.DateCreated = DateTime.UtcNow;
                    entity.CreatedById = httpContextService.CurrentUserId;
                }

                if (entry.State == EntityState.Modified)
                {
                    entry.Property(nameof(DatabaseEntity.DateCreated)).IsModified = false;
                    entry.Property(nameof(DatabaseEntity.CreatedById)).IsModified = false;
                }
            }
        }

        return await context.SaveChangesAsync();
    }

    public void AddLogs(int applicationActionId, List<EntityEntry> modifiedEntries)
    {
        // We're creating new row for every entity
        // Seems like the most visually pleasing way to do it
        modifiedEntries.ForEach(entry =>
        {
            var properties = new List<object>();

            foreach (var prop in entry.Properties
                .Where(p => entry.State != EntityState.Modified
                || entry.State == EntityState.Modified && p.IsModified))
            {
                object newProperty;

                if (entry.State == EntityState.Added)
                {
                    newProperty = new
                    {
                        prop.Metadata.Name,
                        NewValue = prop.CurrentValue
                    };
                }
                else
                {
                    newProperty = new
                    {
                        EntityId = entry.Property(nameof(DatabaseEntity<int>.Id)).CurrentValue,
                        prop.Metadata.Name,
                        prop.OriginalValue,
                        NewValue = prop.CurrentValue
                    };
                }

                properties.Add(newProperty);
            }

            context.Set<AuditLog>().Add(new AuditLog
            {
                ApplicationActionId = applicationActionId,
                // Not EXACT table name but Class name nonetheless
                TableName = entry.Metadata.ClrType.Name,
                State = entry.State.ToString(),
                Changes = JsonConvert.SerializeObject(properties),
                IsDeleted = false,
                DateCreated = DateTime.UtcNow,
                CreatedById = httpContextService.CurrentUserId
            });
        });
    }

    public IRepositoryBase<T, U> GetGenericRepository<T, U>() where U : struct where T : DatabaseEntity<U>
    {
        return repositoryProvider.GetGenericRepository<T, U>();
    }

    public T GetCustomRepository<T>() where T : class
    {
        return repositoryProvider.GetCustomRepository<T>();
    }

    public DbSet<T> GetDbSet<T>() where T : class
    {
        return context.Set<T>();
    }

    public void Dispose()
    {
        context.Dispose();
    }

    public void ClearChangeTracker()
    {
        context.ChangeTracker.Clear();
    }
}
