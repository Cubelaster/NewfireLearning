using System.Collections.Generic;
using Core.Models.EfModels.Codebooks.Base;

namespace Core.Models.EfModels.Codebooks
{
    public class ArticleType : CodebookCompanyBase
    {
        public int AppCodeId { get; set; }
        public AppCode AppCode { get; set; }

        public IEnumerable<Article> Articles { get; set; }
    }
}
