using System;
using ReFilter.Attributes;
using ReFilter.Models;
using ReFilter.Models.Filtering.Contracts;

namespace Core.Models.Requests.Filtering
{
    public class CustomerCreditLimitFilterRequest : IReFilterRequest
    {
        public int? PartnerId { get; set; }

        public RangeFilter<decimal> Amount { get; set; }
        public bool? IsAdditional { get; set; }

        public RangeFilter<DateTime> DateFrom { get; set; }
        public RangeFilter<DateTime> DateTo { get; set; }

        [ReFilterProperty(HasSpecialFilter = true)]
        public DateTime? ValidOn { get; set; }

        public int? CompanyId { get; set; }
    }
}
