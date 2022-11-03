using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Core.Models.EfModels.Base;
using Core.Models.EfModels.Codebooks;
using Core.Models.EfModels.Documents;
using Core.Models.EfModels.Partners;
using Core.Models.EfModels.Promotions;
using ReFilter.Attributes;

namespace Core.Models.EfModels
{
    public class Site : DatabaseEntityTranslated<int>
    {
        [ReFilterProperty(UsedForSearchQuery = true)]
        [StringLength(40), Required]
        public string Code { get; set; }

        [ReFilterProperty(UsedForSearchQuery = true)]
        [StringLength(100)]
        public string Address { get; set; }
        [ReFilterProperty(UsedForSearchQuery = true)]
        [StringLength(100)]
        public string Municipality { get; set; }

        public decimal? GpsLon { get; set; }
        public decimal? GpsLat { get; set; }

        public int PostalCodeId { get; set; }
        public PostalCode PostalCode { get; set; }

        [ReFilterProperty(UsedForSearchQuery = true)]
        [StringLength(100)]
        public string Email { get; set; }
        [ReFilterProperty(UsedForSearchQuery = true)]
        [StringLength(50)]
        public string Phone { get; set; }
        [ReFilterProperty(UsedForSearchQuery = true)]
        [StringLength(50)]
        public string MobilePhone { get; set; }
        [StringLength(50)]
        public string IpAddress { get; set; }

        public int SiteBrandId { get; set; }
        public SiteBrand SiteBrand { get; set; }

        public int SiteCategoryId { get; set; }
        public SiteCategory SiteCategory { get; set; }

        public int SiteFormatId { get; set; }
        public SiteFormat SiteFormat { get; set; }

        public int SiteModelId { get; set; }
        public SiteModel SiteModel { get; set; }

        public int SiteRegionId { get; set; }
        public SiteRegion SiteRegion { get; set; }

        public int SiteStatusId { get; set; }
        public SiteStatus SiteStatus { get; set; }

        public int SiteTypeId { get; set; }
        public SiteType SiteType { get; set; }

        public int WarehouseTypeId { get; set; }
        public WarehouseType WarehouseType { get; set; }

        public int CompanyId { get; set; }
        public Company Company { get; set; }

        public List<PartnerSite> Partners { get; set; }
        public List<SiteSiteContent> Content { get; set; }
        public List<SiteAssortment> Assortments { get; set; }
        public List<SiteSalesPriceType> SalesPriceTypes { get; set; }

        public IEnumerable<Document> Documents { get; set; }
        public IEnumerable<Document> DeliveryDocuments { get; set; }
        public IEnumerable<DocumentItem> DocumentItems { get; set; }
        public IEnumerable<DependentCost> DependentCosts { get; set; }
        public IEnumerable<SalesPrice> SalesPrices { get; set; }

        public IEnumerable<PromotionSite> Promotions { get; set; }
    }
}
