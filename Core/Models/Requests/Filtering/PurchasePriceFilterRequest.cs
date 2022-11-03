using System;
using Core.Models.Requests.Filtering.Base;
using ReFilter.Attributes;
using ReFilter.Models;
using ReFilter.Models.Filtering.Contracts;

namespace Core.Models.Requests.Filtering
{
    public class PurchasePriceFilterRequest : BaseFilterRequest, IReFilterRequest
    {
        public int? ArticleId { get; set; }
        public int? PartnerId { get; set; }

        public RangeFilter<DateOnly> DateFrom { get; set; }
        public RangeFilter<DateOnly> DateTo { get; set; }
        [ReFilterProperty(HasSpecialFilter = true)]
        public DateTime? ValidOn { get; set; }

        public int? CurrencyId { get; set; }

        public RangeFilter<decimal> Price { get; set; }
        public RangeFilter<decimal> PriceNet { get; set; }

        public RangeFilter<decimal> ExciseDuty { get; set; }
        public RangeFilter<decimal> RebatePercentage { get; set; }
        public RangeFilter<decimal> RebateAmount { get; set; }

        public bool? MarginCalculation { get; set; }

        public bool? IsAction { get; set; }

        [ReFilterProperty(HasSpecialFilter = true)]
        public bool? IsCurrentlyActive { get; set; }
    }
}
