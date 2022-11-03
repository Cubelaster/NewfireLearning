using System.Collections.Generic;
using Core.Models.Dtos.Article;
using Core.Models.Dtos.EntityConnectors;
using Core.Models.Requests.PurchasePrice;
using Core.Models.Requests.SalesPrice;

namespace Core.Models.Requests.Article
{
    public class ArticleFullCreateRequest : ArticleCreateRequest
    {
        public List<ArticleAssortmentDto> Assortments { get; set; }
        public List<BarcodeCreateRequest> Barcodes { get; set; }
        public List<PurchasePriceCreateRequest> PurchasePrices { get; set; }
        public List<SalesPriceCreateRequest> SalesPrices { get; set; }
        public List<ArticleTaxTypeDto> TaxTypes { get; set; }
        public List<ArticleAdditionalTaxDto> AdditionalTaxes { get; set; }
        public List<RecipeCreateRequest> ProductRecipes { get; set; }

        public List<EntityNoteDto> Notes { get; set; }
        public List<EntityExternalCodeDto> ExternalCodes { get; set; }
    }
}
