using Core.Enums;
using Core.Models.Requests.Filtering.Base;

namespace Core.Models.Requests.Filtering
{
    public class EntityGridColumnConfigFilterRequest : BaseFilterRequest
    {
        public EntityType? SettingForEntityType { get; set; }
        public string PropertyName { get; set; }

        public bool? IsHidden { get; set; }
        public bool? IsExposed { get; set; }
        public bool? IsEditable { get; set; }

        // Used without FK when linking to specific Types
        public int? CodebookId { get; set; }

        // Used for specific AppCodeId
        public int? AppCodeId { get; set; }
    }
}
