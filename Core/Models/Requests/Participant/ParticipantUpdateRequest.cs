using Core.Models.Requests.Base;

namespace Core.Models.Requests.Participant
{
    public class ParticipantUpdateRequest : ParticipantCreateRequest, IBaseUpdateRequest<int>
    {
        public int? Id { get; set; }
    }
}
