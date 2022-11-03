using System;
using Core.Models.Requests.Base;

namespace Core.Models.Requests.PurchasePrice
{
    public class PurchasePriceCreateRequest : BaseRequest
    {
        public int ArticleId { get; set; }
        public int PartnerId { get; set; }

        public DateOnly DateFrom { get; set; }
        public DateOnly? DateTo { get; set; }

        public int CurrencyId { get; set; }

        public int PriceCalculationRoundingId { get; set; }

        public decimal Price { get; set; }
        public decimal PriceNet { get; set; }

        public decimal ExciseDuty { get; set; }
        public decimal RebatePercentage { get; set; }
        public decimal RebateAmount { get; set; }

        public bool MarginCalculation { get; set; }

        public bool IsAction { get; set; }

        public int CompanyId { get; set; }
    }
}
