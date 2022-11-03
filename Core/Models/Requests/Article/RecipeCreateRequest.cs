using System;
using Core.Models.Requests.Base;

namespace Core.Models.Requests.Article
{
    public class RecipeCreateRequest : BaseRequest
    {
        public int ArticleProductId { get; set; }
        public int ArticleComponentId { get; set; }
        public int UnitOfMeasureId { get; set; }

        public decimal Quantity { get; set; }
        public decimal? Loss { get; set; }

        public DateOnly DateFrom { get; set; }
        public DateOnly? DateTo { get; set; }

        public int CompanyId { get; set; }
    }
}
