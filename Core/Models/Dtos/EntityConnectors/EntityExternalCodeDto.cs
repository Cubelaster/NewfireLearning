using System;
using Core.Models.Dtos.EntityConnectors.Base;
using Core.Models.ViewModels.Codebooks.Base;

namespace Core.Models.Dtos.EntityConnectors
{
    public class EntityExternalCodeDto : EntityConnectorBaseDto
    {
        public int ExternalCodeTypeId { get; set; }
        public CodebookBaseViewModel ExternalCodeType { get; set; }

        public DateOnly? DateFrom { get; set; }
        public DateOnly? DateTo { get; set; }
    }
}
