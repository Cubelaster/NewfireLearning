using Core.Models.Requests.Filtering.Base;

namespace Core.Models.Requests.Filtering
{
    public class AnalysisTypeFilterRequest : BaseFilterRequest
    {
        public string UnitOfMeasure { get; set; }
        public string Method { get; set; }
    }
}
