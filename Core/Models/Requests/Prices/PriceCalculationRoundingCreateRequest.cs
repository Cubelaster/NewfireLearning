using Core.Models.Requests.Base;
using Core.Models.Utility;

namespace Core.Models.Requests.Prices
{
    public class PriceCalculationRoundingCreateRequest : BaseRequest
    {
        public string Name { get; set; }
        public Translations Translations { get; set; }

        public decimal? Modifier { get; set; }
        public decimal? Intervals { get; set; }

        public int PriceCalculationRoundingTypeId { get; set; }

        public int CompanyId { get; set; }
    }
}
