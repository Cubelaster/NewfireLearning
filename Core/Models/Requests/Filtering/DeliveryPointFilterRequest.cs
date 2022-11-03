namespace Core.Models.Requests.Filtering
{
    public class DeliveryPointFilterRequest : CodebooksBaseFilterRequest
    {
        public int? PostalCodeId { get; set; }
    }
}