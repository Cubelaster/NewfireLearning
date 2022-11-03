using Core.Enums;
using Core.Models.ViewModels.Base;

namespace Core.Models.ViewModels.DecimalPlacesSettings
{
    public class DecimalPlacesSettingsViewModel : IBaseViewModel<int>
    {
        public int Id { get; set; }
        public EntityType SettingForEntityType { get; set; }
        public string PropertyName { get; set; }
        public int DecimalPlaces { get; set; }
        public int? TotalCharacters { get; set; }
        public bool HasLeadingZeroes { get; set; }

        public int CompanyId { get; set; }

        public int EntityId => Id;
        public EntityType EntityType => EntityType.DecimalPlacesSettings;
        public string DisplayValue => $"{PropertyName}-{DecimalPlaces}";
    }
}
