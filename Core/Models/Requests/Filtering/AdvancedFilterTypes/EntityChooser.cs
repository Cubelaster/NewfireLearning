using Core.Enums;

namespace Core.Models.Requests.Filtering.AdvancedFilterTypes
{
    public class EntityChooser
    {
        public int? EntityId { get; set; }
        public EntityType? EntityType { get; set; }
    }
}
