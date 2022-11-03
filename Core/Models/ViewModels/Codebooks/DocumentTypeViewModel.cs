using Core.Enums;
using Core.Models.Dtos.EntityConnectors.MetaMaterializations;
using Core.Models.ViewModels.Codebooks.Base;

namespace Core.Models.ViewModels.Codebooks
{
    public class DocumentTypeViewModel : CodebookBaseViewModel
    {
        public int StockImpact { get; set; }
        public int TradeBookDischarge { get; set; }
        public int TradeBookCharge { get; set; }
        public bool PurchasePriceImpact { get; set; }
        public bool OrderImpact { get; set; }

        public int WarehouseTypeId { get; set; }
        public WarehouseTypeViewModel WarehouseType { get; set; }

        public new DocumentTypeEnum Code { get; set; }
        public DocumentTypeMetaDto Meta { get; set; }

        public override string DisplayValue => $"{(int)Code}-{Name}";

    }
}
