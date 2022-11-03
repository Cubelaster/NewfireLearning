using Core.Enums;

namespace Core.Models.Dtos.EntityConnectors.Base
{
    public class EntityConnectorBaseDto
    {
        public int? Id { get; set; }
        public EntityType EntityType { get; set; }
        public int EntityId { get; set; }

        public string? Value { get; set; }
    }
}
