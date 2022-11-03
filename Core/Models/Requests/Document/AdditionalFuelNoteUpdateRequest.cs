using Core.Models.Requests.Base;

namespace Core.Models.Requests.Document
{
    public class AdditionalFuelNoteUpdateRequest : AdditionalFuelNoteCreateRequest, IBaseUpdateRequest<int>
    {
        public int? Id { get; set; }
    }
}
