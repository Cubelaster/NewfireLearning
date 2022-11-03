using System.Collections.Generic;

namespace Core.Models.ViewModels.Codebooks
{
    public class TaxTypeDetailViewModel : TaxTypeGridViewModel
    {
        public List<TaxGroupViewModel> TaxGroups { get; set; }
    }
}
