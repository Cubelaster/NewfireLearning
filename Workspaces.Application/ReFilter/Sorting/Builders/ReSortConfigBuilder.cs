using ReFilter.ReFilterConfigBuilder;
using ReFilter.ReSortBuilder;
using Workspaces.Application.Utility;

namespace Workspaces.Application.ReFilter.Sorting.Builders
{
    internal class ReSortConfigBuilder : IReSortConfigBuilder
    {

        public IReSortBuilder<T> GetMatchingSortBuilder<T>() where T : class, new()
        {
            return typeof(T) switch
            {
                _ => null,
            };
        }

        public Type GetMatchingType<T>() where T : class, new()
        {
            return EntityTypeMatcher.GetEntityTypeConfig<T>().SortRequestType ?? typeof(T);
        }
    }
}