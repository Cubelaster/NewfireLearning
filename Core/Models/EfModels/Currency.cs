using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Core.Models.EfModels.Base;
using Core.Models.EfModels.Codebooks;
using Core.Models.EfModels.Documents;
using Core.Models.EfModels.Partners;
using ReFilter.Attributes;

namespace Core.Models.EfModels
{
    public class Currency : DatabaseEntity<int>
    {
        [ReFilterProperty(UsedForSearchQuery = true)]
        [StringLength(3), Required]
        public string Code { get; set; }
        [ReFilterProperty(UsedForSearchQuery = true)]
        [StringLength(3), Required]
        public string Number { get; set; }
        [ReFilterProperty(UsedForSearchQuery = true)]
        [StringLength(3)]
        public string Symbol { get; set; }

        public int CompanyId { get; set; }
        public Company Company { get; set; }

        public IEnumerable<CurrencyExchangeRate> ExchangeRates { get; set; }
        public IEnumerable<PurchasePrice> PurchasePrices { get; set; }
        public IEnumerable<SalesPrice> SalesPrices { get; set; }
        public IEnumerable<CompanyCurrency> CompanyCurrencies { get; set; }
        public IEnumerable<PartnerCurrency> PartnerCurrencies { get; set; }
        public IEnumerable<Document> Documents { get; set; }
        public IEnumerable<DependentCost> DependentCosts { get; set; }
        public IEnumerable<AdditionalTaxValue> AdditionalTaxValues { get; set; }
    }
}
