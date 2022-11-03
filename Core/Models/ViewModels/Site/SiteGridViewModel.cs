using Core.Models.ViewModels.Codebooks;
using Core.Models.ViewModels.Codebooks.Base;

namespace Core.Models.ViewModels.Site
{
    public class SiteGridViewModel : SiteBaseViewModel
    {
        public int CompanyId { get; set; }

        public string Email { get; set; }
        public string Phone { get; set; }
        public string MobilePhone { get; set; }

        public CodebookBaseViewModel SiteBrand { get; set; }
        public CodebookBaseViewModel SiteCategory { get; set; }
        public CodebookBaseViewModel SiteFormat { get; set; }
        public CodebookBaseViewModel SiteModel { get; set; }
        public CodebookBaseViewModel SiteRegion { get; set; }
        public CodebookBaseViewModel SiteStatus { get; set; }
        public CodebookBaseViewModel SiteType { get; set; }
        public WarehouseTypeViewModel WarehouseType { get; set; }
    }
}
