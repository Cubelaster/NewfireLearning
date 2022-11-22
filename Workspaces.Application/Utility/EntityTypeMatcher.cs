using Core.Enums;
using Core.Models.Utility.Configuration;
using Workspaces.Core.Models.EfModels;

namespace Workspaces.Application.Utility
{
    public static class EntityTypeMatcher
    {
        public static EntityTypeConfig GetEntityTypeConfig<T>()
            where T : class
        {
            // AppCode and AppCode region intentionally missing
            // We're not handling Meta carriers in any way
            return typeof(T) switch
            {
                Type workspaces when workspaces == typeof(Workspace) => new EntityTypeConfig
                {
                    EntityType = EntityType.Workspace,
                    //FilterRequestType = typeof(CodebooksBaseFilterRequest),
                    //SortRequestType = typeof(CodebooksBaseFilterRequest),
                },
                _ => new EntityTypeConfig { EntityType = EntityType.Undefined },
            };
        }
    }
}
