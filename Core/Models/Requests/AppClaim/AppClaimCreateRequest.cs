using Core.Models.Requests.Base;
using Core.Models.Utility;

namespace Core.Models.Requests.AppClaim
{
    public class AppClaimCreateRequest : BaseRequest
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public string Action { get; set; }
        public Translations Allows { get; set; }
        public Translations Description { get; set; }

        public Translations Translations { get; set; }
    }
}
