using System;
using ReFilter.Attributes;
using ReFilter.Models;
using ReFilter.Models.Filtering.Contracts;

namespace Core.Models.Requests.Filtering
{
    public class CustomerPriceFilterRequest : IReFilterRequest
    {
        public int? PartnerId { get; set; }

        public int? ArticleId { get; set; }

        public int? DeliveryPointId { get; set; }

        public int? ParityTermId { get; set; }
        public int? PaymentTermId { get; set; }

        public RangeFilter<DateOnly> DateFrom { get; set; }
        public RangeFilter<DateOnly> DateTo { get; set; }
        [ReFilterProperty(HasSpecialFilter = true)]
        public DateTime? ValidOn { get; set; }

        public RangeFilter<decimal> DiscountPrice { get; set; }
        public RangeFilter<decimal> DiscountPercentage { get; set; }
        public RangeFilter<decimal> FixedPrice { get; set; }

        public int? CompanyId { get; set; }
    }
}
