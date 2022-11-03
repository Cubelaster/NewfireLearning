using System;
using Core.Models.EfModels.Base;

namespace Core.Models.EfModels.Documents
{
    public class DocumentParticipant : DatabaseEntity<int>
    {
        public Guid DocumentId { get; set; }
        public Document Document { get; set; }

        public int ParticipantId { get; set; }
        public Participant Participant { get; set; }
    }
}
