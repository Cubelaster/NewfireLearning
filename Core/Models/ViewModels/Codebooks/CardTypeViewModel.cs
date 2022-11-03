using Core.Models.ViewModels.Codebooks.Base;

namespace Core.Models.ViewModels.Codebooks
{
    public class CardTypeViewModel : CodebookBaseViewModel
    {
        public string ExternalCode { get; set; }
        public string Description { get; set; }
    }
}