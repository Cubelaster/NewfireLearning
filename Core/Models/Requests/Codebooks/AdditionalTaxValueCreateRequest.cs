using System;
using Core.Models.Requests.Base;

namespace Core.Models.Requests.Codebooks
{
    public class AdditionalTaxValueCreateRequest : BaseRequest
    {
        public int AdditionalTaxId { get; set; }

        public int CurrencyId { get; set; }

        public decimal? AmountPercentage { get; set; }
        public decimal? AmountFixed { get; set; }

        public DateOnly DateFrom { get; set; }
        public DateOnly? DateTo { get; set; }
    }
}
