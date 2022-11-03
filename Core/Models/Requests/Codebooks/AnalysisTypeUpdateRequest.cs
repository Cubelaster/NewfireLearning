using Core.Models.Requests.Base;

namespace Core.Models.Requests.Codebooks
{
    public class AnalysisTypeUpdateRequest : AnalysisTypeCreateRequest, IBaseUpdateRequest<int>
    {
        public int? Id { get; set; }
    }
}
