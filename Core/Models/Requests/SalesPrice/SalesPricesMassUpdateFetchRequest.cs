using System;
using System.Collections.Generic;
using Core.Models.Requests.Base;

namespace Core.Models.Requests.SalesPrice
{
    public class SalesPricesMassUpdateFetchRequest : BaseRequest
    {
        public DateTime ValidOn { get; set; }
        public List<int> SalePriceTypeIds { get; set; }
        public List<int> SalePriceGroupIds { get; set; }
        public List<int> SiteIds { get; set; }

        public double? ArticleCodeFrom { get; set; }
        public double? ArticleCodeTo { get; set; }

        public List<int> ArticleTypeIds { get; set; }
        public List<int> ArticleTypeAppCodeIds { get; set; }
        public List<int> ArticleCategoryIds { get; set; }

        public int? PartnerId { get; set; }

        public int CompanyId { get; set; }
    }
}
