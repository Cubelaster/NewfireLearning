using System.Collections.Generic;
using Core.Enums;
using Core.Models.Dtos.EntityConnectors.MetaMaterializations;
using Core.Models.EfModels.Codebooks.Base;
using Core.Models.EfModels.Documents;

namespace Core.Models.EfModels.Codebooks
{
    public class DocumentType : MetaCarrierBase
    {
        public int StockImpact { get; set; }
        public int TradeBookDischarge { get; set; }
        public int TradeBookCharge { get; set; }
        public bool PurchasePriceImpact { get; set; }
        public bool OrderImpact { get; set; }

        public new DocumentTypeEnum Code { get; set; }
        public new DocumentTypeMetaDto Meta { get; set; }

        public int WarehouseTypeId { get; set; }
        public WarehouseType WarehouseType { get; set; }

        public IEnumerable<Document> Documents { get; set; }
    }
}
