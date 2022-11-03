using Core.Models.Requests.Codebooks.Base;

namespace Core.Models.Requests.Codebooks
{
    public class PaymentMethodCreateRequest : CodebookBaseCreateRequest
    {
        public int PaymentGroupId { get; set; }
    }
}
