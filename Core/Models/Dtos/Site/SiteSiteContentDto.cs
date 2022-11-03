using Core.Models.ViewModels.Codebooks.Base;

namespace Core.Models.Dtos.Site
{
    public class SiteSiteContentDto
    {
        public int? Id { get; set; }
        public int SiteId { get; set; }
        public int SiteContentId { get; set; }
        public CodebookBaseViewModel SiteContent { get; set; }
    }
}
