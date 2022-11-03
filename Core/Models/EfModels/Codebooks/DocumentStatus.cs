using System.Collections.Generic;
using Core.Enums;
using Core.Models.Dtos.EntityConnectors.MetaMaterializations;
using Core.Models.EfModels.Codebooks.Base;
using Core.Models.EfModels.Documents;

namespace Core.Models.EfModels.Codebooks
{
    public class DocumentStatus : MetaCarrierBase
    {
        public new DocumentStatusEnum Code { get; set; }
        public new DocumentStatusMetaDto Meta { get; set; }

        public IEnumerable<Document> Documents { get; set; }
    }
}
