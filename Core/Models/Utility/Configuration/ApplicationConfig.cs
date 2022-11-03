using System;
using System.Collections.Generic;
using Core.Enums;
using Core.Models.ViewModels.Codebooks;
using Core.Models.ViewModels.Codebooks.Base;
using Core.Models.ViewModels.Codebooks.EntityConnectorTypeViewModels;

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
        public List<DocumentStatusViewModel> DocumentStatuses { get; set; }
        public List<DocumentTypeViewModel> DocumentTypes { get; set; }
        public List<CodebookBaseViewModel> ExternalCodeTypes { get; set; }
        public List<NoteTypeViewModel> NoteTypes { get; set; }
        public List<CodebookBaseViewModel> PriceRoundingTypes { get; set; }
        public List<WarehouseTypeViewModel> WarehouseTypes { get; set; }
    }
}
