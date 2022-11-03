using System;
using Core.Models.Requests.Filtering.Base;
using ReFilter.Attributes;
using ReFilter.Models;

namespace Core.Models.Requests.Filtering
{
    public class TaxGroupFilterRequest : BaseFilterRequest
    {
        public int? TaxTypeId { get; set; }

        public RangeFilter<decimal> TaxPercentage { get; set; }
        public bool? SpecialTaxPercentage { get; set; }
        public RangeFilter<DateOnly> DateFrom { get; set; }
        public RangeFilter<DateOnly> DateTo { get; set; }

        [ReFilterProperty(HasSpecialFilter = true)]
        public DateTime? ValidOn { get; set; }
    }
}
