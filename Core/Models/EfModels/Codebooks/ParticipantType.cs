using System.Collections.Generic;
using Core.Models.EfModels.Codebooks.Base;

namespace Core.Models.EfModels.Codebooks
{
    public class ParticipantType : CodebookCompanyBase
    {
        public int AppCodeId { get; set; }
        public AppCode AppCode { get; set; }

        public IEnumerable<Participant> Participants { get; set; }
    }
}
