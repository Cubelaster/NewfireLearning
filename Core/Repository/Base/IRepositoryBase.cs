using System.Linq.Expressions;
using Core.Models.EfModels.Base;
using Core.Repository.Utility;

namespace Core.Repository.Base
{
    public interface IRepositoryBase<T, U> where U : struct where T : DatabaseEntity<U>
    {
        IQueryable<T> GetAll(Expression<Func<T, bool>> filter = null,
                       Func<IQueryable<T>, IOrderedEnumerable<T>> orderBy = null,
                       string includeProperties = "");

        IQueryable<T> GetActive(Expression<Func<T, bool>> filter = null,
            Func<IQueryable<T>, IOrderedEnumerable<T>> orderBy = null,
            string includeProperties = "");

        /// <summary>
        /// Adds a AsNoTracking to Query
        /// Use it for reading
        /// </summary>
        /// <param name="filter"></param>
        /// <param name="orderBy"></param>
        /// <returns></returns>
        IQueryable<T> ReadAll(Expression<Func<T, bool>> filter = null,
            Func<IQueryable<T>, IOrderedEnumerable<T>> orderBy = null);

        IQueryable<T> ReadActive(Expression<Func<T, bool>> filter = null, QueryBuildingOptions options = null);

        T FindSingle(U id);

        T FindSingle(Guid id);

        T FindSingle(int id);

        T FindBy(Expression<Func<T, bool>> predicate, string includeProperties = "");

        void Add(T toAdd);

        /// <summary>
        /// Exception to the rule.
        /// Please don't use this
        /// </summary>
        /// <param name="toAdd"></param>
        void AddIdentityInsertOn(T toAdd);

        void AddRange(List<T> toAdd);

        void Update(T toUpdate);

        void Delete(U id);

        void Delete(Guid id);

        void Delete(int id);

        void Delete(T entity);

        void DeleteBulk(IEnumerable<U> ids);

        void DeleteBulk(IEnumerable<T> entitiesToDelete);
    }
}
