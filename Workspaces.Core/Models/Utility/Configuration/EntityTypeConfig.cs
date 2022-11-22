using Core.Enums;

namespace Workspaces.Core.Models.Utility.Configuration;

public class EntityTypeConfig
{
    public EntityType EntityType { get; set; }
    public Type FilterRequestType { get; set; }
    public Type SortRequestType { get; set; }
    public Type Validator { get; set; }
}
