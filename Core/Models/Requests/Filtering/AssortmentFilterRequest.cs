using ReFilter.Models;

namespace Core.Models.Requests.Filtering
{
    public class AssortmentFilterRequest : CodebooksBaseFilterRequest
    {
        public new RangeFilter<int> Code { get; set; }
    }
}
