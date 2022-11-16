using Core.Enums;
using Core.Models.ViewModels.Codebooks;
using Core.Models.ViewModels.Codebooks.Base;

namespace Core.Models.Utility.Configuration
{
    public class ApplicationConfig
    {
        public DateTime ServerTime { get; set; }
        public TimeZoneInfo ServerTimeZone { get; set; }

        public ApplicationInfo ApplicationInfo { get; set; }

        public List<string> ConnectionStringNames { get; set; }

        public Dictionary<EntityType, List<AppCodeViewModel>> CodesDictionary { get; set; }

        public List<CodebookBaseViewModel> AddressTypes { get; set; }
        public List<CodebookBaseViewModel> ContactTypes { get; set; }
        public List<CodebookBaseViewModel> PriceRoundingTypes { get; set; }
    }
}
