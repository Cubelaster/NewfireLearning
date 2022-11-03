using Core.Models.Requests.Base;

namespace Core.Models.Requests.ApplicationAction
{
    public class ApplicationActionDefinitionUpdateRequest : ApplicationActionDefinitionCreateRequest, IBaseUpdateRequest<int>
    {
        public int? Id { get; set; }
    }
}
