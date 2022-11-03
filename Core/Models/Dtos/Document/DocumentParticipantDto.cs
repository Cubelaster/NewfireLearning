using System;
using Core.Models.ViewModels.Participant;

namespace Core.Models.Dtos.Document
{
    public class DocumentParticipantDto
    {
        public int? Id { get; set; }
        public Guid DocumentId { get; set; }
        public int ParticipantId { get; set; }
        public ParticipantViewModel Participant { get; set; }
    }
}
