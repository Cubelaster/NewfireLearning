using Core.Enums;
using Core.Models.ViewModels.Base;
using Core.Models.ViewModels.Codebooks;

namespace Core.Models.ViewModels.Configs
{
    public class EntityGridColumnConfigViewModel : IBaseViewModel<int>
    {
        public int Id { get; set; }

        public EntityType SettingForEntityType { get; set; }
        public string PropertyName { get; set; }

        public bool IsHidden { get; set; }
        public bool IsExposed { get; set; }
        public bool IsEditable { get; set; }

        // Used without FK when linking to specific Types
        public int? CodebookId { get; set; }

        // Used for specific AppCodeId
        public int? AppCodeId { get; set; }
        public AppCodeViewModel AppCode { get; set; }

        public string AdditionalConfig { get; set; }

        public int EntityId => Id;
        public EntityType EntityType => EntityType.EntityGridColumnConfig;
        public string DisplayValue => "";
    }
}