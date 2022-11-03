using System;
using System.ComponentModel.DataAnnotations;
using Core.Models.EfModels.Base;
using Core.Models.EfModels.Codebooks;
using Core.Models.EfModels.Partners;

namespace Core.Models.EfModels.Documents
{
    public class DependentCost : DatabaseEntity<Guid>
    {
        public Guid DocumentId { get; set; }
        public Document Document { get; set; }

        public int SiteId { get; set; }
        public Site Site { get; set; }

        public int Year { get; set; }
        public int OrdinalNumber { get; set; }

        public int PartnerId { get; set; }
        public Partner Partner { get; set; }
        [StringLength(255)]
        public string PartnerName { get; set; }
        [StringLength(255)]
        public string PartnerAddress { get; set; }
        [StringLength(255)]
        public string PartnerPostalCode { get; set; }

        public int FeeTypeId { get; set; }
        public FeeType FeeType { get; set; }

        public int CurrencyId { get; set; }
        public Currency Currency { get; set; }
        public decimal ExchangeRate { get; set; }

        public int TaxTypeId { get; set; }
        public TaxType TaxType { get; set; }
        public decimal TaxPercentage { get; set; }

        public decimal Quantity { get; set; }
        public decimal PurchasePriceCurrency { get; set; }
        public decimal PurchasePrice { get; set; }
        public decimal PurchasePriceNetTotal { get; set; }
        public decimal PurchasePriceTaxAmountTotal { get; set; }
        public decimal PurchasePriceTotal { get; set; }


        public int CompanyId { get; set; }
        public Company Company { get; set; }
    }
}
