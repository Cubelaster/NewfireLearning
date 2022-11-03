using System;
using Core.Models.EfModels.Base;
using Core.Models.EfModels.Codebooks;

namespace Core.Models.EfModels.Documents
{
    public class AdditionalFuelNote : DatabaseEntity<int>
    {
        public Guid DocumentId { get; set; }
        public Document Document { get; set; }

        public string Value { get; set; }

        public int AdditionalFuelNoteTypeId { get; set; }
        public AdditionalFuelNoteType AdditionalFuelNoteType { get; set; }

        public int CompanyId { get; set; }
        public Company Company { get; set; }
    }
}
