using System;
using Core.Enums;
using Core.Models.ViewModels.Base;
using Core.Models.ViewModels.Codebooks.Base;

namespace Core.Models.ViewModels.Participant
{
    public class ParticipantViewModel : IBaseViewModel<int>
    {
        public int Id { get; set; }

        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Code { get; set; }

        public CodebookBaseViewModel ParticipantType { get; set; }

        public int? TransporterId { get; set; }

        public DateOnly DateFrom { get; set; }
        public DateOnly? DateTo { get; set; }

        public int EntityId => Id;
        public EntityType EntityType => EntityType.Participant;
        public string DisplayValue => $"{(FirstName ?? "")} {(LastName ?? "")}";
    }
}
