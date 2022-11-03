using Core.Models.Requests.Base;

namespace Core.Models.Requests.Prices
{
    public class PriceCalculationRoundingUpdateRequest : PriceCalculationRoundingCreateRequest, IBaseUpdateRequest<int>
    {
        public int? Id { get; set; }
    }
}
