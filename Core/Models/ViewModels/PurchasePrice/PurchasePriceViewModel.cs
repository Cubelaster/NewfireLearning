using System;
using Core.Enums;
using Core.Models.ViewModels.Article;
using Core.Models.ViewModels.Base;
using Core.Models.ViewModels.Codebooks;
using Core.Models.ViewModels.Company;
using Core.Models.ViewModels.Partner;

namespace Core.Models.ViewModels.PurchasePrice
{
    public class PurchasePriceViewModel : IBaseViewModel<Guid>
    {
        public Guid Id { get; set; }

        public int ArticleId { get; set; }
        public ArticleBaseViewModel Article { get; set; }

        public int PartnerId { get; set; }
        public PartnerBaseViewModel Partner { get; set; }

        public DateOnly DateFrom { get; set; }
        public DateOnly? DateTo { get; set; }

        public int CurrencyId { get; set; }
        public CurrencyViewModel Currency { get; set; }

        public decimal Price { get; set; }
        public decimal PriceNet { get; set; }

        public decimal ExciseDuty { get; set; }
        public decimal RebatePercentage { get; set; }
        public decimal RebateAmount { get; set; }

        public bool MarginCalculation { get; set; }

        public bool IsAction { get; set; }

        public int CompanyId { get; set; }
        public CompanyBaseViewModel Company { get; set; }

        public Guid EntityId => Id;
        public EntityType EntityType => EntityType.PurchasePrice;
        public string DisplayValue => Id.ToString();
    }
}
