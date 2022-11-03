using System;
using Core.Models.Requests.Base;

namespace Core.Models.Requests.Document
{
    public class DependentCostCreateRequest : BaseRequest
    {
        public Guid DocumentId { get; set; }

        public int SiteId { get; set; }

        public int Year { get; set; }
        public int OrdinalNumber { get; set; }

        public int PartnerId { get; set; }

        public string PartnerName { get; set; }
        public string PartnerAddress { get; set; }
        public string PartnerPostalCode { get; set; }

        public int FeeTypeId { get; set; }

        public int CurrencyId { get; set; }
        public decimal ExchangeRate { get; set; }

        public int TaxTypeId { get; set; }
        public decimal TaxPercentage { get; set; }

        public decimal Quantity { get; set; }
        public decimal PurchasePriceCurrency { get; set; }
        public decimal PurchasePrice { get; set; }
        public decimal PurchasePriceNetTotal { get; set; }
        public decimal PurchasePriceTaxAmountTotal { get; set; }
        public decimal PurchasePriceTotal { get; set; }

        public int CompanyId { get; set; }
    }
}
