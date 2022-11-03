using System;
using Core.Models.EfModels.Base;
using Core.Models.EfModels.Codebooks;
using Core.Models.EfModels.Partners;

namespace Core.Models.EfModels.Documents
{
    public class DocumentPayment : DatabaseEntity<int>
    {
        public Guid DocumentId { get; set; }
        public Document Document { get; set; }

        public int PaymentMethodId { get; set; }
        public PaymentMethod PaymentMethod { get; set; }

        public int? PartnerId { get; set; }
        public Partner Partner { get; set; }

        public decimal Amount { get; set; }
    }
}
