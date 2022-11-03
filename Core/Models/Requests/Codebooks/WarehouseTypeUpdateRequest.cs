using Core.Models.Requests.Base;

namespace Core.Models.Requests.Codebooks
{
    public class WarehouseTypeUpdateRequest : WarehouseTypeCreateRequest, IBaseUpdateRequest<int>
    {
        public int? Id { get; set; }
    }
}
