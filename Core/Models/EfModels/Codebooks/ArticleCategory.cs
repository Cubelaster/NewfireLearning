using System.Collections.Generic;
using Core.Models.EfModels.Codebooks.Base;

namespace Core.Models.EfModels.Codebooks
{
    public class ArticleCategory : CodebookCompanyBase
    {
        public int? ParentId { get; set; }
        public ArticleCategory Parent { get; set; }

        public List<ArticleCategory> Children { get; set; }

        public IEnumerable<Article> Articles { get; set; }
    }
}
