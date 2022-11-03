using Core.Models.ViewModels.Codebooks.Base;

namespace Core.Models.Dtos.Article
{
    public class ArticleAdditionalTaxDto
    {
        public int Id { get; set; }
        public int ArticleId { get; set; }
        public int AdditionalTaxId { get; set; }
        public CodebookBaseViewModel? AdditionalTax { get; set; }

        public DateOnly DateFrom { get; set; }
        public DateOnly? DateTo { get; set; }
    }
}
