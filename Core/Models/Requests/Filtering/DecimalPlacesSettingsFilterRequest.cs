using Core.Enums;
using ReFilter.Models;
using ReFilter.Models.Filtering.Contracts;

namespace Core.Models.Requests.Filtering
{
    public class DecimalPlacesSettingsFilterRequest : IReFilterRequest
    {
        public EntityType? SettingForEntityType { get; set; }
        public string PropertyName { get; set; }
        public RangeFilter<int> DecimalPlaces { get; set; }
        public RangeFilter<int> TotalCharacters { get; set; }
        public bool? HasLeadingZeroes { get; set; }


        public int? CompanyId { get; set; }
    }
}
