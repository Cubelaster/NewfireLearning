using Core.Enums;
using Core.Models.Utility;
using Core.Models.ViewModels.Base;

namespace Core.Models.ViewModels.Site
{
    public class SiteBaseViewModel : IBaseViewModel<int>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public Translations Translations { get; set; }

        public int EntityId => Id;
        public EntityType EntityType => EntityType.Site;
        public string DisplayValue => $"{Code}-{Name}";
    }
}
