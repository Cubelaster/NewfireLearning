using Core.Enums;
using Core.Models.Requests.Base;

namespace Core.Models.Requests.DecimalPlacesSettings
{
    public class DecimalPlacesSettingsCreateRequest : BaseRequest
    {
        public EntityType SettingForEntityType { get; set; }
        public string PropertyName { get; set; }
        public int DecimalPlaces { get; set; }
        public int? TotalCharacters { get; set; }
        public bool HasLeadingZeroes { get; set; }

        public int CompanyId { get; set; }
    }
}
