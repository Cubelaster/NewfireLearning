using System;
using Core.Models.EfModels.Base;
using Core.Models.EfModels.Codebooks;

namespace Core.Models.EfModels.Partners
{
    // TODO When defining Cascade Deletes it is necessary to
    // Define every single posible path explicitly
    // Or maybe, not sure, it's enough to select a single Cascade and set the rest to NoAction
    public class CustomerPrice : DatabaseEntity<Guid>
    {
        public int PartnerId { get; set; }
        public Partner Partner { get; set; }

        public int ArticleId { get; set; }
        public Article Article { get; set; }

        public int DeliveryPointId { get; set; }
        public DeliveryPoint DeliveryPoint { get; set; }

        public int ParityTermId { get; set; }
        public ParityTerm ParityTerm { get; set; }

        public int PaymentTermId { get; set; }
        public PaymentTerm PaymentTerm { get; set; }

        public DateOnly DateFrom { get; set; }
        public DateOnly? DateTo { get; set; }

        public decimal? DiscountPrice { get; set; }
        public decimal? DiscountPercentage { get; set; }
        public decimal? FixedPrice { get; set; }

        public int CompanyId { get; set; }
        public Company Company { get; set; }
    }
}
