using Core.Enums;
using Core.Models.Utility;
using Core.Models.ViewModels.Base;

namespace Core.Models.ViewModels.Codebooks
{
    public class AppCodeViewModel : IBaseViewModel<int>
    {
        public int Id { get; set; }
        public EntityType EntityTypeKey { get; set; }
        public int Key { get; set; }
        public string Name { get; set; }

        public int? SortOrder { get; set; }
        public string Description { get; set; }
        public string Meta { get; set; }

        public Translations Translations { get; set; }

        public int EntityId => Id;
        public EntityType EntityType => EntityType.AppCode;
        public string DisplayValue => $"{Key}-{Name}";
    }
}
