namespace Core.Models.Requests.Filtering
{
    public class DocumentTypeFilterRequest : CodebooksBaseFilterRequest
    {
        public int? StockImpact { get; set; }
        public int? TradeBookDischarge { get; set; }
        public int? TradeBookCharge { get; set; }
        public bool? PurchasePriceImpact { get; set; }
        public bool? OrderImpact { get; set; }
    }
}
