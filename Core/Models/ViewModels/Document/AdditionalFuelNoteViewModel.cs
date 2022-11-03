using System;
using Core.Enums;
using Core.Models.ViewModels.Base;
using Core.Models.ViewModels.Codebooks.Base;

namespace Core.Models.ViewModels.Document
{
    public class AdditionalFuelNoteViewModel : IBaseViewModel<int>
    {
        public int Id { get; set; }
        public Guid DocumentId { get; set; }

        public string Value { get; set; }

        public int AdditionalFuelNoteTypeId { get; set; }
        public CodebookBaseViewModel AdditionalFuelNoteType { get; set; }

        public int CompanyId { get; set; }

        public int EntityId => Id;
        public EntityType EntityType => EntityType.AdditionalFuelNote;
        public string DisplayValue => Value;
    }
}
