using System.Collections.Generic;
using Core.Models.ViewModels.SalesPrice;

namespace Core.Models.Requests.SalesPrice
{
    public class SalesPricesMassUpdateRequest : SalesPricesMassUpdateFetchRequest
    {
        public List<SalesPriceMassUpdateViewModel> SalesPrices { get; set; }
        public bool AllowOverlapModification { get; set; }
    }
}
