using System.Collections.Generic;
using Core.Models.EfModels.Codebooks.Base;

namespace Core.Models.EfModels
{
    public class Assortment : CodebookCompanyBase
    {
        public IEnumerable<ArticleAssortment> AssortmentArticles { get; set; }
        public IEnumerable<SiteAssortment> SiteAssortments { get; set; }
    }
}
