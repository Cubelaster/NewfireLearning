using System;
using Core.Models.Requests.Filtering.Base;
using ReFilter.Models;

namespace Core.Models.Requests.Filtering
{
    public class RecipeFilterRequest : BaseFilterRequest
    {
        public int? ArticleProductId { get; set; }
        public int? ArticleComponentId { get; set; }
        public int? UnitOfMeasureId { get; set; }

        public RangeFilter<decimal> Quantity { get; set; }
        public RangeFilter<decimal> Loss { get; set; }

        public RangeFilter<DateOnly> DateFrom { get; set; }
        public RangeFilter<DateOnly> DateTo { get; set; }
    }
}
