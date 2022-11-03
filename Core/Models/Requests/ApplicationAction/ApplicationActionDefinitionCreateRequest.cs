using Core.Models.Requests.Base;

namespace Core.Models.Requests.ApplicationAction
{
    public class ApplicationActionDefinitionCreateRequest : BaseRequest
    {
        public string ActionOwnerName { get; set; }
        public string ActionName { get; set; }
        public string RequestSignature { get; set; }
        public string ResponseSignature { get; set; }
    }
}
