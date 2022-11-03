using System.Collections.Generic;

namespace Core.Models.Requests.Filtering
{
    public class PostalCodeFilterRequest : CodebooksBaseFilterRequest
    {
        public int? CountryId { get; set; }
        public List<int> CountryIds { get; set; }
    }
}
