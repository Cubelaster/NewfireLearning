using Core.Enums;
using Core.Models.Utility;
using Core.Models.ViewModels.Base;

namespace Core.Models.ViewModels.Article
{
    public class ArticleBaseViewModel : IBaseViewModel<int>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }

        public Translations Translations { get; set; }

        public int UnitOfMeasureId { get; set; }
        public decimal Quantity { get; set; }
        public int UnitOfMeasureQuantitativeId { get; set; }
        public decimal? DepositRefund { get; set; }
        public int ArticleTypeId { get; set; }
        public int ArticleCategoryId { get; set; }
        public bool IsActive { get; set; }
        public int CompanyId { get; set; }

        public int EntityId => Id;
        public EntityType EntityType => EntityType.Article;
        public string DisplayValue => $"{Code}-{Name}";
    }
}
