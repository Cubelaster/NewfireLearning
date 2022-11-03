using Core.Enums;
using Core.Models.Utility;
using Core.Models.ViewModels.Base;

namespace Core.Models.ViewModels.AppClaim
{
    public class ClaimTreeViewModel : IBaseViewModel<int>
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public EntityType ClaimFamilyType { get; set; }

        public Translations Allows { get; set; }
        public Translations Description { get; set; }

        public Translations Translations { get; set; }

        public int EntityId => Id;
        public EntityType EntityType => ClaimFamilyType;
        public string DisplayValue => "";
    }
}
