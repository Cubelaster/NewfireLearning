using System;
using Core.Models.EfModels.Base;

namespace Core.Models.EfModels.Codebooks
{
    public class TaxGroup : DatabaseEntity<int>
    {
        public decimal TaxPercentage { get; set; }

        public bool SpecialTaxPercentage { get; set; }

        public int TaxTypeId { get; set; }
        public TaxType TaxType { get; set; }

        public DateOnly DateFrom { get; set; }
        public DateOnly? DateTo { get; set; }

        public int CompanyId { get; set; }
        public Company Company { get; set; }
    }
}
