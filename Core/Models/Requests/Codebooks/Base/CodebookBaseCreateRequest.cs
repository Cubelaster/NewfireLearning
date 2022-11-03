using Core.Models.Requests.Base;
using Core.Models.Utility;

namespace Core.Models.Requests.Codebooks.Base
{
    public class CodebookBaseCreateRequest : BaseRequest
    {
        public string Name { get; set; }
        public Translations Translations { get; set; }

        public string Code { get; set; }

        public int? AppCodeId { get; set; }

        public int? CompanyId { get; set; }
    }
}
