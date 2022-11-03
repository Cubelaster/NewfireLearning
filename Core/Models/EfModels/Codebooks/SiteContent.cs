using System.Collections.Generic;
using Core.Models.EfModels.Codebooks.Base;
namespace Core.Models.EfModels.Codebooks
{
    public class SiteContent : CodebookCompanyBase
    {
        public IEnumerable<SiteSiteContent> Sites { get; set; }
    }
}
