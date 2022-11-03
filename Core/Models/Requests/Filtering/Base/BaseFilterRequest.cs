using ReFilter.Models.Filtering.Contracts;

namespace Core.Models.Requests.Filtering.Base
{
    public class BaseFilterRequest : IReFilterRequest
    {
        public string Name { get; set; }
        public int? CompanyId { get; set; }
    }
}
