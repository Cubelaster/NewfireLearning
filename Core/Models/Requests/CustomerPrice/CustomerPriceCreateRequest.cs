using System;
using Core.Models.Requests.Base;

namespace Core.Models.Requests.CustomerPrice
{
    public class CustomerPriceCreateRequest : BaseRequest
    {
        public int PartnerId { get; set; }

        public int ArticleId { get; set; }

        public int DeliveryPointId { get; set; }

        public int ParityTermId { get; set; }
        public int PaymentTermId { get; set; }

        public DateOnly DateFrom { get; set; }
        public DateOnly? DateTo { get; set; }

        public decimal? DiscountPrice { get; set; }
        public decimal? DiscountPercentage { get; set; }
        public decimal? FixedPrice { get; set; }

        public int CompanyId { get; set; }
    }
}
