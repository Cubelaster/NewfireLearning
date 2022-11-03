using System;
using ReFilter.Models;

namespace Core.Models.Requests.Filtering
{
    public class PromotionFilterRequest : CodebooksBaseFilterRequest
    {
        public int? PromotionTypeId { get; set; }
        public int? CombinationTypeId { get; set; }
        public int? DisplayTypeId { get; set; }
        public int? MarketingActionTypeId { get; set; }

        public RangeFilter<DateOnly> DateFrom { get; set; }
        public RangeFilter<DateOnly> DateTo { get; set; }
        public RangeFilter<TimeSpan> TimeFrom { get; set; }
        public RangeFilter<TimeSpan> TimeTo { get; set; }

        public string Days { get; set; }

        public bool? IsForForecourt { get; set; }

        public string MarketingMessage { get; set; }
        public RangeFilter<int> CodeLength { get; set; }

        public bool? IsCombo { get; set; }
        public RangeFilter<int> ComboScale { get; set; } //ToDo: ne znamo sta je
        public RangeFilter<decimal> Price { get; set; }

        public bool? IsBinRange { get; set; }

        public string Psp { get; set; }

        public RangeFilter<int> OrderNo { get; set; }

        public bool? ShowOnPos { get; set; }
        public bool? ShowOnCustomerDisplay { get; set; }
    }
}
