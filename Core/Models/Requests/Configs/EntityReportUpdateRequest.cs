using Core.Models.Requests.Base;

namespace Core.Models.Requests.Configs
{
    public class EntityReportUpdateRequest : EntityReportCreateRequest, IBaseUpdateRequest<int>
    {
        public int? Id { get; set; }
    }
}
