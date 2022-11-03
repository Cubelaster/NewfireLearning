using Core.Models.ViewModels.Codebooks.Base;

namespace Core.Models.ViewModels.Article
{
    public class ArticleGridViewModel : ArticleBaseViewModel
    {
        public string NameShort { get; set; }
        public CodebookBaseViewModel UnitOfMeasure { get; set; }
        public CodebookBaseViewModel UnitOfMeasureQuantitative { get; set; }
        public CodebookBaseViewModel ArticleType { get; set; }
        public CodebookBaseViewModel ArticleCategory { get; set; }
    }
}
