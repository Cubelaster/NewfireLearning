using System.Collections.Generic;
using Core.Models.Dtos.Partner;
using Core.Models.Dtos.Site;
using Core.Models.ViewModels.Codebooks;

namespace Core.Models.ViewModels.Site
{
    public class SiteDetailViewModel : SiteGridViewModel
    {
        public string Address { get; set; }
        public string Municipality { get; set; }

        public decimal GpsLon { get; set; }
        public decimal GpsLat { get; set; }

        public PostalCodeViewModel PostalCode { get; set; }

        public string IpAddress { get; set; }

        public List<PartnerSiteDto> Partners { get; set; }
        public List<SiteSiteContentDto> Content { get; set; }
        public List<SiteAssortmentDto> Assortments { get; set; }
        public List<SiteSalesPriceTypeDto> SalesPriceTypes { get; set; }
    }
}
