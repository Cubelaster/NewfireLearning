using Core.Enums;
using Core.Models.Utility;
using Core.Models.ViewModels.Base;

namespace Core.Models.ViewModels.Promotion
{
    public class PromotionBaseViewModel : IBaseViewModel<int>
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public Translations Translations { get; set; }

        public int CompanyId { get; set; }

        public int EntityId => Id;
        public EntityType EntityType => EntityType.Promotion;
        public string DisplayValue => Code;
    }
}
