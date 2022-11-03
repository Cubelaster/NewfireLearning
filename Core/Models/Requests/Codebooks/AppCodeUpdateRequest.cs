using Core.Models.Requests.Base;

namespace Core.Models.Requests.Codebooks
{
    public class AppCodeUpdateRequest : AppCodeCreateRequest, IBaseUpdateRequest<int>
    {
        public int? Id { get; set; }
    }
}
