using Core.Enums;
using Core.Models.Utility;
using Core.Models.ViewModels.Base;
using Core.Models.ViewModels.Codebooks.Base;

namespace Core.Models.ViewModels.Prices
{
    public class PriceCalculationRoundingViewModel : IBaseViewModel<int>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Translations Translations { get; set; }

        public decimal? Modifier { get; set; }
        public decimal? Intervals { get; set; }

        public int PriceCalculationRoundingTypeId { get; set; }
        public CodebookBaseViewModel PriceCalculationRoundingType { get; set; }

        public int CompanyId { get; set; }

        public int EntityId => Id;
        public EntityType EntityType => EntityType.PriceCalculationRounding;
        public string DisplayValue => Name;
    }
}
