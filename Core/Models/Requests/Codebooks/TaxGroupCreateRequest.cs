using System;
using Core.Models.Requests.Base;
using Core.Models.Utility;

namespace Core.Models.Requests.Codebooks
{
    public class TaxGroupCreateRequest : BaseRequest
    {
        public Translations Translations { get; set; }

        public int TaxTypeId { get; set; }

        public decimal? TaxPercentage { get; set; }
        public bool SpecialTaxPercentage { get; set; }

        public DateOnly DateFrom { get; set; }
        public DateOnly? DateTo { get; set; }

        public int? CompanyId { get; set; }
    }
}
