using System.Collections.Generic;
using Core.Models.Requests.Base;
using Core.Models.Requests.PurchasePrice;
using Core.Models.Requests.SalesPrice;

namespace Core.Models.Requests.Article
{
    public class ArticleFullUpdateRequest : ArticleFullCreateRequest, IBaseUpdateRequest<int>
    {
        public int? Id { get; set; }

        public new List<BarcodeUpdateRequest> Barcodes { get; set; }
        public new List<PurchasePriceUpdateRequest> PurchasePrices { get; set; }
        public new List<SalesPriceUpdateRequest> SalesPrices { get; set; }
        public new List<RecipeUpdateRequest> ProductRecipes { get; set; }
    }
}
