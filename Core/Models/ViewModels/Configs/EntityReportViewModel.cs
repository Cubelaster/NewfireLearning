using Core.Enums;
using Core.Models.ViewModels.Base;
using Core.Models.ViewModels.Codebooks;

namespace Core.Models.ViewModels.Configs
{
    public class EntityReportViewModel : IBaseViewModel<int>
    {
        public int Id { get; set; }

        public EntityType ForEntityType { get; set; }
        public string Name { get; set; }
        public string Path { get; set; }

        // Used without FK when linking to specific Types
        public int? CodebookId { get; set; }

        // Used for specific AppCodeId
        public int? AppCodeId { get; set; }
        public AppCodeViewModel AppCode { get; set; }

        public int EntityId => Id;
        public EntityType EntityType => EntityType.EntityReport;
        public string DisplayValue => "";
    }
}
