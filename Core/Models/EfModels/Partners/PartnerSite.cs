using System;
using Core.Models.EfModels.Base;

namespace Core.Models.EfModels.Partners
{
    public class PartnerSite : DatabaseEntity<int>
    {
        public int PartnerId { get; set; }
        public Partner Partner { get; set; }

        public int SiteId { get; set; }
        public Site Site { get; set; }
    }
}
