using Core.Models.Requests.Base;

namespace Core.Models.Requests.Codebooks.EntityConnectorTypes
{
    public class NoteTypeUpdateRequest : NoteTypeCreateRequest, IBaseUpdateRequest<int>
    {
        public int? Id { get; set; }
    }
}
