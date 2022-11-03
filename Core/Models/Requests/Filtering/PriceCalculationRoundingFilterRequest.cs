using Core.Models.Requests.Filtering.Base;
using ReFilter.Models;
using ReFilter.Models.Filtering.Contracts;

namespace Core.Models.Requests.Filtering
{
    public class PriceCalculationRoundingFilterRequest : BaseFilterRequest, IReFilterRequest
    {
        public RangeFilter<decimal> Modifier { get; set; }
        public RangeFilter<decimal> Intervals { get; set; }

        public int? PriceCalculationRoundingTypeId { get; set; }
    }
}
