using System.Collections.Generic;
using Core.Models.Dtos.Article;

namespace Core.Models.ViewModels.Article
{
    public class ArticleDetailViewModel : ArticleGridViewModel
    {
        public List<ArticleAssortmentDto> Assortments { get; set; }
        public List<BarcodeViewModel> Barcodes { get; set; }
        public List<ArticleTaxTypeDto> TaxTypes { get; set; }
        public List<ArticleAdditionalTaxDto> AdditionalTaxes { get; set; }
    }
}
