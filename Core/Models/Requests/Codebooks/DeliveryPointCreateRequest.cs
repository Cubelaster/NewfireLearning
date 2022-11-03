using Core.Models.Requests.Codebooks.Base;

namespace Core.Models.Requests.Codebooks
{
    public class DeliveryPointCreateRequest : CodebookBaseCreateRequest
    {
        public int PostalCodeId { get; set; }
    }
}
