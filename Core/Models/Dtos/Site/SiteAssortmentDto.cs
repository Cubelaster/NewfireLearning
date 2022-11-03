using Core.Models.ViewModels.Codebooks.Base;

namespace Core.Models.Dtos.Site
{
    public class SiteAssortmentDto
    {
        public int? Id { get; set; }
        public int SiteId { get; set; }
        public int AssortmentId { get; set; }
        public CodebookBaseViewModel? Assortment { get; set; }
    }
}
