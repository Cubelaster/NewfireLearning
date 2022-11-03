using Core.Enums;
using Core.Models.Requests.Codebooks.Base;

namespace Core.Models.Requests.Codebooks
{
    public class WarehouseTypeCreateRequest : CodebookBaseCreateRequest
    {
        public new WarehouseTypeEnum Code { get; set; }
    }
}
