using System;
using System.Collections.Generic;
using Core.Models.Dtos.EntityConnectors;
using Core.Models.Requests.Base;

namespace Core.Models.Requests.Participant
{
    public class ParticipantCreateRequest : BaseRequest
    {
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Code { get; set; }
        public int ParticipantTypeId { get; set; }
        public int? TransporterId { get; set; }
        public int CompanyId { get; set; }

        public DateOnly DateFrom { get; set; }
        public DateOnly? DateTo { get; set; }

        public List<EntityContactDto> Contacts { get; set; }
    }
}
