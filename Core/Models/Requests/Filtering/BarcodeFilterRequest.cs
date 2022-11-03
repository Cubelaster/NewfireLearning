using Core.Models.Requests.Filtering.Base;
using ReFilter.Attributes;
using ReFilter.Models;

namespace Core.Models.Requests.Filtering
{
    public class BarcodeFilterRequest : BaseFilterRequest
    {
        public string BarCode { get; set; }

        public RangeFilter<int> Quantity { get; set; }

        [ReFilterProperty(HasSpecialFilter = false, HasSpecialSort = true)]
        public int? UnitOfMeasureId { get; set; }

        [ReFilterProperty(HasSpecialFilter = false, HasSpecialSort = true)]
        public int? ArticleId { get; set; }
    }
}
