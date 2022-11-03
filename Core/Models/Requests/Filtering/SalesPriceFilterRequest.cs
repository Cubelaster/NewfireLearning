using System;
using System.Collections.Generic;
using Core.Models.Requests.Filtering.Base;
using ReFilter.Attributes;
using ReFilter.Models;
using ReFilter.Models.Filtering.Contracts;

namespace Core.Models.Requests.Filtering
{
    public class SalesPriceFilterRequest : BaseFilterRequest, IReFilterRequest
    {
        public int? ArticleId { get; set; }
        public int? SiteId { get; set; }
        public int? SalePriceTypeId { get; set; }
        public int? SalePriceGroupId { get; set; }
        public int? PriceCalculationRoundingId { get; set; }

        [ReFilterProperty(HasSpecialFilter = true)]
        public List<int> SalePriceTypeIds { get; set; }
        [ReFilterProperty(HasSpecialFilter = true)]
        public List<int> SalePriceGroupIds { get; set; }
        [ReFilterProperty(HasSpecialFilter = true)]
        public List<int> SiteIds { get; set; }

        public RangeFilter<DateOnly> DateFrom { get; set; }
        public RangeFilter<DateOnly> DateTo { get; set; }
        [ReFilterProperty(HasSpecialFilter = true)]
        public DateTime? ValidOn { get; set; }

        [ReFilterProperty(HasSpecialFilter = true)]
        public DateTime? ValidAfter { get; set; }

        public int? CurrencyId { get; set; }

        public RangeFilter<decimal> Price { get; set; }
        public RangeFilter<decimal> PriceNet { get; set; }
        public RangeFilter<decimal> ExciseDuty { get; set; }
        public RangeFilter<decimal> MarginPercentage { get; set; }
        public RangeFilter<decimal> MarginAmount { get; set; }
        public RangeFilter<decimal> PackageRefundFee { get; set; }
        public RangeFilter<decimal> DiscountPercentage { get; set; }
        public RangeFilter<decimal> DiscountAmount { get; set; }

        public bool? IsAction { get; set; }

        [ReFilterProperty(HasSpecialFilter = true)]
        public bool? IsCurrentlyActive { get; set; }
    }
}
