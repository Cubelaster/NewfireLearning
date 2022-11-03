using ReFilter.Models.Filtering.Contracts;

namespace Core.Models.Requests.Filtering
{
    public class CountryFilterRequest : IReFilterRequest
    {
        public string Name { get; set; }
        public string Code { get; set; }
    }
}
