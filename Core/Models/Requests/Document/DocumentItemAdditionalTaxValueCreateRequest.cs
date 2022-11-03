using System;
using Core.Models.Requests.Base;

namespace Core.Models.Requests.Document
{
    public class DocumentItemAdditionalTaxValueCreateRequest : BaseRequest
    {
        public Guid DocumentItemId { get; set; }

        public int AdditionalTaxId { get; set; }

        public decimal? AmountPercentage { get; set; }
        public decimal? AmountFixed { get; set; }
    }
}
