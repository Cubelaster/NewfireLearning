namespace Core.Models.Requests.Filtering
{
    public class PaymentMethodFilterRequest : CodebooksBaseFilterRequest
    {
        public int? PaymentGroupId { get; set; }
    }
}
