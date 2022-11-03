using Core.Enums;
using Core.Models.Dtos.EntityConnectors.MetaMaterializations;
using Core.Models.Requests.Codebooks.Base;

namespace Core.Models.Requests.Codebooks
{
    public class DocumentStatusCreateRequest : CodebookBaseCreateRequest
    {
        public new DocumentStatusEnum Code { get; set; }
        public DocumentStatusMetaDto Meta { get; set; }
    }
}
