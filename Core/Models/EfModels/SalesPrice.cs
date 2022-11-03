using System;
using Core.Models.EfModels.Base;
using Core.Models.EfModels.Codebooks;

namespace Core.Models.EfModels
{
    public class SalesPrice : DatabaseEntity<Guid>
    {
        public int ArticleId { get; set; }
        public Article Article { get; set; }

        public int? SalePriceTypeId { get; set; }
        public SalesPriceType SalePriceType { get; set; }

        public int? SalePriceGroupId { get; set; }
        public SalesPriceGroup SalePriceGroup { get; set; }

        public int? SiteId { get; set; }
        public Site Site { get; set; }

        public DateOnly DateFrom { get; set; }
        public DateOnly? DateTo { get; set; }

        public int CurrencyId { get; set; }
        public Currency Currency { get; set; }

        // Next 3 are denormalized for logging and other purposes
        public decimal WeightedPurchasePrice { get; set; }
        public decimal VatPercentage { get; set; }
        public decimal VatAmount { get; set; }

        public decimal MarginPercentage { get; set; }
        public decimal MarginAmount { get; set; }
        public decimal ExciseDuty { get; set; }
        public decimal PackageRefundFee { get; set; }

        public decimal DiscountPercentage { get; set; }
        public decimal DiscountAmount { get; set; }

        public decimal PriceNet { get; set; }
        public decimal Price { get; set; }

        public int? PriceCalculationRoundingId { get; set; }
        public PriceCalculationRounding PriceCalculationRounding { get; set; }

        public bool IsAction { get; set; }

        public int CompanyId { get; set; }
        public Company Company { get; set; }
    }
}
