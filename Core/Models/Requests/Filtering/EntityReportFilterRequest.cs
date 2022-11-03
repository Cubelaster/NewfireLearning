using Core.Enums;
using Core.Models.Requests.Filtering.Base;

namespace Core.Models.Requests.Filtering
{
    public class EntityReportFilterRequest : BaseFilterRequest
    {
        public EntityType? ForEntityType { get; set; }

        public int? CodebookId { get; set; }
        public int? AppCodeId { get; set; }
    }
}
