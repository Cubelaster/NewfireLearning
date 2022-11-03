using Core.Models.Requests.Filtering.Base;

namespace Core.Models.Requests.Filtering
{
    public class CodebooksBaseFilterRequest : BaseFilterRequest
    {
        public string Code { get; set; }

        public int? AppCodeId { get; set; }
    }
}
