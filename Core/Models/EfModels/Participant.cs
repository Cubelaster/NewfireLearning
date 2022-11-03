using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Core.Models.EfModels.Base;
using Core.Models.EfModels.Codebooks;
using Core.Models.EfModels.Documents;
using Core.Models.EfModels.EntityConnectors;
using Core.Models.EfModels.Partners;
using ReFilter.Attributes;

namespace Core.Models.EfModels
{
    public class Participant : DatabaseEntity<int>
    {
        [ReFilterProperty]
        [StringLength(255)]
        public string FirstName { get; set; }
        [ReFilterProperty]
        [StringLength(255)]
        public string MiddleName { get; set; }
        [ReFilterProperty]
        [StringLength(255)]
        public string LastName { get; set; }
        [ReFilterProperty]
        public string Code { get; set; }

        public int ParticipantTypeId { get; set; }
        public ParticipantType ParticipantType { get; set; }

        public DateOnly DateFrom { get; set; }
        public DateOnly? DateTo { get; set; }

        public int? TransporterId { get; set; }
        public Partner Transporter { get; set; }

        public int CompanyId { get; set; }
        public Company Company { get; set; }

        public IEnumerable<DocumentParticipant> Documents { get; set; }

        [NotMapped]
        public IEnumerable<EntityContact> Contacts { get; set; }
    }
}
