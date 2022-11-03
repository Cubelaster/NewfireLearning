using Core.Enums;
using Core.Models.Dtos.EntityConnectors.MetaMaterializations;
using Core.Models.Requests.Codebooks.Base;

namespace Core.Models.Requests.Codebooks
{
    public class DocumentTypeCreateRequest : CodebookBaseCreateRequest
    {
        public int StockImpact { get; set; }
        public int TradeBookDischarge { get; set; }
        public int TradeBookCharge { get; set; }
        public bool PurchasePriceImpact { get; set; }
        public bool OrderImpact { get; set; }

        public int WarehouseTypeId { get; set; }

        public new DocumentTypeEnum Code { get; set; }
        public DocumentTypeMetaDto Meta { get; set; }
    }
}
