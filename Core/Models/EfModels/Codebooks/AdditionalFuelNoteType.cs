using System.Collections.Generic;
using Core.Models.EfModels.Codebooks.Base;
using Core.Models.EfModels.Documents;

namespace Core.Models.EfModels.Codebooks
{
    public class AdditionalFuelNoteType : CodebookCompanyBase
    {
        public IEnumerable<AdditionalFuelNote> AdditionalFuelNotes { get; set; }
    }
}
