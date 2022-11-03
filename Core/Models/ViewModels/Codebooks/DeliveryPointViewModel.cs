using Core.Models.ViewModels.Codebooks.Base;

namespace Core.Models.ViewModels.Codebooks
{
    public class DeliveryPointViewModel : CodebookBaseViewModel
    {
        public int PostalCodeId { get; set; }
        public PostalCodeViewModel PostalCode { get; set; }
    }
}
