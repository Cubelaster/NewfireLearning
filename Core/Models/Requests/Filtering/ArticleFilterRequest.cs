using System.Collections.Generic;
using Core.Models.Requests.Filtering.Base;
using ReFilter.Attributes;
using ReFilter.Models;

namespace Core.Models.Requests.Filtering
{
    public class ArticleFilterRequest : BaseFilterRequest
    {
        public string Code { get; set; }
        public string NameShort { get; set; }

        [ReFilterProperty(HasSpecialFilter = true, HasSpecialSort = true)]
        public RangeFilter<double> CodeRange { get; set; }

        [ReFilterProperty(HasSpecialFilter = true, HasSpecialSort = true)]
        public List<int> UnitOfMeasureIds { get; set; }
        [ReFilterProperty(HasSpecialFilter = true, HasSpecialSort = true)]
        public List<int> UnitOfMeasureQuantitativeIds { get; set; }
        [ReFilterProperty(HasSpecialFilter = true, HasSpecialSort = true)]
        public List<int> ArticleTypeIds { get; set; }
        [ReFilterProperty(HasSpecialFilter = true, HasSpecialSort = true)]
        public List<int> ArticleTypeAppCodeIds { get; set; }
        [ReFilterProperty(HasSpecialFilter = true, HasSpecialSort = true)]
        public List<int> ArticleCategoryIds { get; set; }

        [ReFilterProperty(HasSpecialFilter = true)]
        public RangeFilter<decimal> Quantity { get; set; }

        [ReFilterProperty(HasSpecialFilter = true)]
        public bool? HasPurchasePrices { get; set; }
    }
}
