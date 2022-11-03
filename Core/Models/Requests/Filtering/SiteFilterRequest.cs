using System.Collections.Generic;
using Core.Models.Requests.Filtering.Base;
using ReFilter.Models.Filtering.Contracts;

namespace Core.Models.Requests.Filtering
{
    public class SiteFilterRequest : BaseFilterRequest, IReFilterRequest
    {
        public string Code { get; set; }
        public string Address { get; set; }
        public string Municipality { get; set; }

        public List<int> PostalCodeIds { get; set; }

        public string Email { get; set; }
        public string Phone { get; set; }
        public string MobilePhone { get; set; }

        public List<int> SiteBrandIds { get; set; }
        public List<int> SiteCategoryIds { get; set; }
        public List<int> SiteFormatIds { get; set; }
        public List<int> SiteModelIds { get; set; }
        public List<int> SiteRegionIds { get; set; }
        public List<int> SiteStatusIds { get; set; }
        public List<int> SiteTypeIds { get; set; }
    }
}
