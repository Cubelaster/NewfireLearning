using System;
using Core.Models.EfModels.Base;
using Core.Models.EfModels.Codebooks;

namespace Core.Models.EfModels.Documents
{
    public class DocumentItemAdditionalTaxValue : DatabaseEntity<Guid>
    {
        public Guid DocumentItemId { get; set; }
        public DocumentItem DocumentItem { get; set; }

        public int AdditionalTaxId { get; set; }
        public AdditionalTax AdditionalTax { get; set; }

        public decimal? AmountPercentage { get; set; }
        public decimal? AmountFixed { get; set; }
    }
}
