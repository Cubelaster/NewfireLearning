using Core.Enums;
using Core.Models.Requests.Base;

namespace Core.Models.Requests.Configs
{
    public class EntityReportCreateRequest : BaseRequest
    {
        public EntityType ForEntityType { get; set; }

        public string Name { get; set; }
        public string Path { get; set; }

        // Used without FK when linking to specific Types
        public int? CodebookId { get; set; }

        // Used for specific AppCodeId
        public int? AppCodeId { get; set; }

        public int CompanyId { get; set; }
    }
}