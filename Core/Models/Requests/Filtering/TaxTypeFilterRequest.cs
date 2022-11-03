namespace Core.Models.Requests.Filtering
{
    public class TaxTypeFilterRequest : CodebooksBaseFilterRequest
    {
        public int? CountryId { get; set; }
    }
}
