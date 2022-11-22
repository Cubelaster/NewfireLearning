namespace Core.Repository.Utility
{
    public class QueryBuildingOptions
    {
        /// <summary>
        /// Sets query execution as multiple subqueries instead of one giant join.
        /// Sometimes you want that
        /// </summary>
        public bool AsSplitQuery { get; set; } = false;
        /// <summary>
        /// Actually set inside UnitOfWork and it's methods
        /// </summary>
        public bool AsNoTracking { get; set; } = true;
        /// <summary>
        /// Not used at the moment
        /// </summary>
        public bool AsParalell { get; set; } = false;
    }
}
