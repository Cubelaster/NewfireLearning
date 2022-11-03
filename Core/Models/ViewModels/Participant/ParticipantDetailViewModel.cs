using Core.Models.ViewModels.Partner;

namespace Core.Models.ViewModels.Participant
{
    public class ParticipantDetailViewModel : ParticipantViewModel
    {
        public PartnerBaseViewModel Transporter { get; set; }
    }
}
