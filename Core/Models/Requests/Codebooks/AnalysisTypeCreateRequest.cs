using Core.Models.Requests.Codebooks.Base;

namespace Core.Models.Requests.Codebooks
{
    public class AnalysisTypeCreateRequest : CodebookBaseCreateRequest
    {
        public string UnitOfMeasure { get; set; }
        public string Method { get; set; }
    }
}
