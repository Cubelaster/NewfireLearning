using Core.Enums;

namespace Core.Models.Dtos.EntityConnectors.MetaMaterializations
{
    public record NoteTypeMetaDto
    {
        public bool UsedOnInvoice { get; set; }
        public bool UsedOnComprehensiveInvoice { get; set; }
        public List<EntityType> AvailableFor { get; set; }
    }
}
