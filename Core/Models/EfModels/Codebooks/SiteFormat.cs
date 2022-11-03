using System.Collections.Generic;
using Core.Models.EfModels.Codebooks.Base;

namespace Core.Models.EfModels.Codebooks
{
    public class SiteFormat : CodebookCompanyBase
    {
        public IEnumerable<Site> Sites { get; set; }
    }
}
