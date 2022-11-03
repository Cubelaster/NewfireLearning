using System.Collections.Generic;
using Core.Models.ViewModels.Codebooks.Base;

namespace Core.Models.ViewModels.Codebooks
{
    public class AdditionalTaxDetailViewModel : CodebookBaseViewModel
    {
        public List<AdditionalTaxValueViewModel> AdditionalTaxValues { get; set; }
    }
}
