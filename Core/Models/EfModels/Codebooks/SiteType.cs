using System.Collections.Generic;
using Core.Models.EfModels.Codebooks.Base;

namespace Core.Models.EfModels.Codebooks
{
    public class SiteType : CodebookCompanyBase
    {
        public IEnumerable<Site> Sites { get; set; }
    }
}
