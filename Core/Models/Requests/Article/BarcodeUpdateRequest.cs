using Core.Models.Requests.Base;

namespace Core.Models.Requests.Article
{
    public class BarcodeUpdateRequest : BarcodeCreateRequest, IBaseUpdateRequest<int>
    {
        public int? Id { get; set; }
    }
}
