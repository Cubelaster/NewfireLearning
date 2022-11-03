using Core.Models.ViewModels.Codebooks.Base;

namespace Core.Models.ViewModels.Codebooks
{
    public class PaymentMethodViewModel : CodebookBaseViewModel
    {
        public int PaymentGroupId { get; set; }
        public AppCodeViewModel PaymentGroup { get; set; }
    }
}
