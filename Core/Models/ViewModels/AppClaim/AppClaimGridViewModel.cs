using Core.Enums;
using Core.Models.Utility;
using Core.Models.ViewModels.Base;

namespace Core.Models.ViewModels.AppClaim
{
    public class AppClaimGridViewModel : IBaseViewModel<int>
    {
        public int Id { get; set; }

        public Translations Allows { get; set; }
        public Translations Description { get; set; }

        public Translations Translations { get; set; }

        public int EntityId => Id;
        public EntityType EntityType => EntityType.AppClaim;
        public string DisplayValue => "";
    }
}
