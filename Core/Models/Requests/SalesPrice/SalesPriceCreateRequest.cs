using System;
using Core.Models.Requests.Base;

namespace Core.Models.Requests.SalesPrice
{
    public class SalesPriceCreateRequest : BaseRequest
    {
        public int ArticleId { get; set; }

        public int? SiteId { get; set; }

        public int? SalePriceTypeId { get; set; }

        public int? SalePriceGroupId { get; set; }

        public int? PriceCalculationRoundingId { get; set; }

        public DateOnly DateFrom { get; set; }
        public DateOnly? DateTo { get; set; }

        public int CurrencyId { get; set; }

        public int CompanyId { get; set; }

        public decimal? Price { get; set; }
        public decimal? PriceNet { get; set; }

        public decimal? ExciseDuty { get; set; }
        public decimal? MarginPercentage { get; set; }
        public decimal? MarginAmount { get; set; }
        public decimal PackageRefundFee { get; set; }

        public decimal DiscountPercentage { get; set; }
        public decimal DiscountAmount { get; set; }

        public decimal? VatPercentage { get; set; }
        public decimal? VatAmount { get; set; }
        public decimal? WeightedPurchasePrice { get; set; }

        public bool IsAction { get; set; }
    }
}
