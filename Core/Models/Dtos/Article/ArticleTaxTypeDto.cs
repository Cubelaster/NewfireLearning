using Core.Models.ViewModels.Codebooks.Base;

namespace Core.Models.Dtos.Article
{
    public class ArticleTaxTypeDto
    {
        public int Id { get; set; }
        public int ArticleId { get; set; }
        public int TaxTypeId { get; set; }
        public CodebookBaseViewModel? TaxType { get; set; }
        public DateOnly DateFrom { get; set; }
        public DateOnly? DateTo { get; set; }
    }
}
