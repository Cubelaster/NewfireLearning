using Core.Models.ViewModels.Article;
using Core.Models.ViewModels.Codebooks;
using Core.Models.ViewModels.Codebooks.Base;
using Core.Models.ViewModels.Partner;

namespace Core.Models.ViewModels.CustomerPrice
{
    public class CustomerPriceGridViewModel : CustomerPriceBaseViewModel
    {
        public PartnerBaseViewModel Partner { get; set; }
        public ArticleBaseViewModel Article { get; set; }
        public DeliveryPointViewModel DeliveryPoint { get; set; }
        public CodebookBaseViewModel ParityTerm { get; set; }
        public CodebookBaseViewModel PaymentTerm { get; set; }
    }
}
