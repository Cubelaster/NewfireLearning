using System.Collections.Generic;
using Core.Models.Dtos.Partner;
using Core.Models.Dtos.Site;
using Core.Models.Requests.Base;
using Core.Models.Utility;

namespace Core.Models.Requests.Site
{
    public class SiteCreateRequest : BaseRequest
    {
        public string Name { get; set; }
        public string Code { get; set; }
        public string Address { get; set; }
        public string Municipality { get; set; }

        public decimal? GpsLon { get; set; }
        public decimal? GpsLat { get; set; }

        public int PostalCodeId { get; set; }

        public string Email { get; set; }
        public string Phone { get; set; }
        public string MobilePhone { get; set; }

        public string IpAddress { get; set; }

        public Translations Translations { get; set; }

        public int SiteBrandId { get; set; }
        public int SiteCategoryId { get; set; }
        public int SiteContentId { get; set; }
        public int SiteFormatId { get; set; }
        public int SiteModelId { get; set; }
        public int SiteRegionId { get; set; }
        public int SiteStatusId { get; set; }
        public int SiteTypeId { get; set; }
        public int WarehouseTypeId { get; set; }

        public int CompanyId { get; set; }

        public List<PartnerSiteDto> Partners { get; set; }
        public List<SiteSiteContentDto> Content { get; set; }
        public List<SiteAssortmentDto> Assortments { get; set; }
        public List<SiteSalesPriceTypeDto> SalesPriceTypes { get; set; }
    }
}
