using System.Collections.Generic;
using Core.Enums;

namespace Core.Models.Dtos.EntityConnectors.MetaMaterializations
{
    public record DocumentStatusMetaDto
    {
        public bool IsEditable { get; set; }
        public bool IsStatusChangeActionExposed { get; set; }
        public bool IsQuantityInverted { get; set; }
        public List<DocumentStatusEnum> AvailableStatuses { get; set; }
        public bool ShouldModifyExisting { get; set; }
        public bool ShouldCreateNew { get; set; }
        public DocumentStatusEnum? NewDocumentStatus { get; set; }
        public DocumentTypeEnum? NewDocumentType { get; set; }
        public List<string> ResetValuesOnNew { get; set; }
    }
}
