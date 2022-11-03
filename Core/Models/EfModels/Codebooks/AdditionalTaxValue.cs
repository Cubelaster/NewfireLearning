using System;
using Core.Models.EfModels.Base;

namespace Core.Models.EfModels.Codebooks
{
    public class AdditionalTaxValue : DatabaseEntity<int>
    {
        public int AdditionalTaxId { get; set; }
        public AdditionalTax AdditionalTax { get; set; }

        public int CurrencyId { get; set; }
        public Currency Currency { get; set; }

        public decimal? AmountPercentage { get; set; }
        public decimal? AmountFixed { get; set; }

        public DateOnly DateFrom { get; set; }
        public DateOnly? DateTo { get; set; }
    }
}
