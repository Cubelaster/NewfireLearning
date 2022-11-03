using System;
using Core.Enums;
using Core.Models.ViewModels.Base;
using Core.Models.ViewModels.Codebooks;
using Core.Models.ViewModels.Codebooks.Base;
using Core.Models.ViewModels.Partner;

namespace Core.Models.ViewModels.Document
{
    public class DependentCostViewModel : IBaseViewModel<Guid>
    {
        public Guid Id { get; set; }

        public Guid DocumentId { get; set; }

        public int SiteId { get; set; }
        public string Year { get; set; }
        public int OrdinalNumber { get; set; }

        public int PartnerId { get; set; }
        public PartnerBaseViewModel Partner { get; set; }

        public string PartnerName { get; set; }
        public string PartnerAddress { get; set; }
        public string PartnerPostalCode { get; set; }

        public int FeeTypeId { get; set; }
        public CodebookBaseViewModel FeeType { get; set; }

        public int CurrencyId { get; set; }
        public CurrencyViewModel Currency { get; set; }
        public decimal ExchangeRate { get; set; }

        public int TaxTypeId { get; set; }
        public CodebookBaseViewModel TaxType { get; set; }
        public decimal TaxPercentage { get; set; }

        public decimal Quantity { get; set; }
        public decimal PurchasePriceCurrency { get; set; }
        public decimal PurchasePrice { get; set; }
        public decimal PurchasePriceNetTotal { get; set; }
        public decimal PurchasePriceTaxAmountTotal { get; set; }
        public decimal PurchasePriceTotal { get; set; }

        public int CompanyId { get; set; }

        public Guid EntityId => Id;
        public EntityType EntityType => EntityType.DependentCost;
        public string DisplayValue => null;
    }
}
