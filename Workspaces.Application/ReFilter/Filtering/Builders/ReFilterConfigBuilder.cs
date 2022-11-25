using ReFilter.ReFilterProvider;
using ReFilter.ReFilterTypeMatcher;
using Workspaces.Application.Utility;

namespace Workspaces.Application.ReFilter.Filtering.Builders
{
    internal class ReFilterConfigBuilder : IReFilterConfigBuilder
    {
        public Type GetMatchingType<T>() where T : class, new()
        {
            return EntityTypeMatcher.GetEntityTypeConfig<T>().FilterRequestType ?? typeof(T);
        }

        public IReFilterBuilder<T> GetMatchingFilterBuilder<T>() where T : class, new()
        {
            return typeof(T) switch
            {
                _ => null,
            };
        }
    }
}
