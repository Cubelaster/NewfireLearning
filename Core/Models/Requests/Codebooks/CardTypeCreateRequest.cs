namespace Core.Models.Requests.Codebooks.Base
{
    public class CardTypeCreateRequest : CodebookBaseCreateRequest
    {
        public string ExternalCode { get; set; }
        public string Description { get; set; }
    }
}
