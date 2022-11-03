using Core.Enums;
using Core.Models.Requests.Base;

namespace Core.Models.Requests.Configs
{
    public class EntityGridColumnConfigCreateRequest : BaseRequest
    {
        public EntityType SettingForEntityType { get; set; }

        public string PropertyName { get; set; }

        public bool IsHidden { get; set; }
        public bool IsExposed { get; set; }
        public bool IsEditable { get; set; }

        // Used without FK when linking to specific Types
        public int? CodebookId { get; set; }

        // Used for specific AppCodeId
        public int? AppCodeId { get; set; }

        public string AdditionalConfig { get; set; }

        public int CompanyId { get; set; }
    }
}
