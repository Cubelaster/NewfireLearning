using Core.Models.ViewModels.Codebooks.Base;

namespace Core.Models.ViewModels.Codebooks
{
    public class TaxTypeGridViewModel : CodebookBaseViewModel
    {
        public int CountryId { get; set; }
        public CountryViewModel Country { get; set; }
    }
}
