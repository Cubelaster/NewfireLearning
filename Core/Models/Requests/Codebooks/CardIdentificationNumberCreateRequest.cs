using Core.Models.Requests.Codebooks.Base;

namespace Core.Models.Requests.Codebooks
{
    public class CardIdentificationNumberCreateRequest : CodebookBaseCreateRequest
    {
        public string Number { get; set; }
        public int RangeId { get; set; }
    }
}
