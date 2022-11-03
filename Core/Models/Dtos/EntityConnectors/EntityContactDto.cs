using System;
using Core.Models.Dtos.EntityConnectors.Base;
using Core.Models.ViewModels.Codebooks.Base;

namespace Core.Models.Dtos.EntityConnectors
{
    public class EntityContactDto : EntityConnectorBaseDto
    {
        public int ContactTypeId { get; set; }
        public CodebookBaseViewModel ContactType { get; set; }

        public bool IsPreffered { get; set; }
        public string Description { get; set; }

        public DateOnly? DateFrom { get; set; }
        public DateOnly? DateTo { get; set; }
    }
}
