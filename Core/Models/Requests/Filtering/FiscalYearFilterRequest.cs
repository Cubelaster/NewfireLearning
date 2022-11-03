using System;
using Core.Models.Requests.Filtering.Base;
using ReFilter.Attributes;
using ReFilter.Models;

namespace Core.Models.Requests.Filtering
{
    public class FiscalYearFilterRequest : BaseFilterRequest
    {
        public RangeFilter<int> Year { get; set; }
        public RangeFilter<DateOnly> DateFrom { get; set; }
        public RangeFilter<DateOnly> DateTo { get; set; }
        [ReFilterProperty(HasSpecialFilter = true)]
        public DateOnly? ValidOn { get; set; }
        public bool? IsLocked { get; set; }
    }
}
