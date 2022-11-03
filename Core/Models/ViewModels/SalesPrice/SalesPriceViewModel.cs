using System;
using Core.Enums;
using Core.Models.ViewModels.Article;
using Core.Models.ViewModels.Base;
using Core.Models.ViewModels.Codebooks;
using Core.Models.ViewModels.Codebooks.Base;
using Core.Models.ViewModels.Company;
using Core.Models.ViewModels.Prices;
using Core.Models.ViewModels.Site;

namespace Core.Models.ViewModels.SalesPrice
{
    public class SalesPriceViewModel : IBaseViewModel<Guid>
    {
        public Guid Id { get; set; }

        public int ArticleId { get; set; }
        public ArticleBaseViewModel Article { get; set; }

        public int? SiteId { get; set; }
        public SiteBaseViewModel Site { get; set; }

        public int? SalePriceTypeId { get; set; }
        public CodebookBaseViewModel SalePriceType { get; set; }

        public int? SalePriceGroupId { get; set; }
        public CodebookBaseViewModel SalePriceGroup { get; set; }

        public DateOnly DateFrom { get; set; }
        public DateOnly? DateTo { get; set; }

        public int CurrencyId { get; set; }
        public CurrencyViewModel Currency { get; set; }

        public decimal Price { get; set; }
        public decimal PriceNet { get; set; }

        public decimal ExciseDuty { get; set; }
        public decimal MarginPercentage { get; set; }
        public decimal MarginAmount { get; set; }
        public decimal PackageRefundFee { get; set; }

        public decimal DiscountPercentage { get; set; }
        public decimal DiscountAmount { get; set; }

        public decimal? VatPercentage { get; set; }
        public decimal? VatAmount { get; set; }
        public decimal? WeightedPurchasePrice { get; set; }

        public int? PriceCalculationRoundingId { get; set; }
        public PriceCalculationRoundingViewModel PriceCalculationRounding { get; set; }

        public bool IsAction { get; set; }

        public int CompanyId { get; set; }
        public CompanyBaseViewModel Company { get; set; }

        public Guid EntityId => Id;
        public EntityType EntityType => EntityType.SalesPrice;
        public string DisplayValue => Id.ToString();
    }
}
