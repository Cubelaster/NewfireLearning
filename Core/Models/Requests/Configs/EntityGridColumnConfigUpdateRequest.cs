using Core.Models.Requests.Base;

namespace Core.Models.Requests.Configs
{
    public class EntityGridColumnConfigUpdateRequest : EntityGridColumnConfigCreateRequest, IBaseUpdateRequest<int>
    {
        public int? Id { get; set; }
    }
}
