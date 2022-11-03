using System;
using Core.Models.Requests.Base;

namespace Core.Models.Requests.Document
{
    public class DocumentPaymentCreateRequest : BaseRequest
    {
        public Guid DocumentId { get; set; }

        public int PaymentMethodId { get; set; }

        public int? PartnerId { get; set; }

        public decimal Amount { get; set; }
    }
}
