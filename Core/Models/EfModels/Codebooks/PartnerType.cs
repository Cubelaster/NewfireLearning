using System.Collections.Generic;
using Core.Models.EfModels.Codebooks.Base;
using Core.Models.EfModels.Partners;

namespace Core.Models.EfModels.Codebooks
{
    public class PartnerType : CodebookCompanyBase
    {
        public int AppCodeId { get; set; }
        public AppCode AppCode { get; set; }

        public IEnumerable<PartnerPartnerType> Partners { get; set; }
    }
}
