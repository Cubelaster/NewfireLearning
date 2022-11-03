using System;
using Core.Enums;
using Core.Models.ViewModels.Base;
using Core.Models.ViewModels.Codebooks.Base;

namespace Core.Models.ViewModels.Article
{
    public class RecipeViewModel : IBaseViewModel<int>
    {
        public int Id { get; set; }

        public int ArticleProductId { get; set; }
        public ArticleBaseViewModel ArticleProduct { get; set; }

        public int ArticleComponentId { get; set; }
        public ArticleBaseViewModel ArticleComponent { get; set; }

        public int UnitOfMeasureId { get; set; }
        public CodebookBaseViewModel UnitOfMeasure { get; set; }

        public decimal Quantity { get; set; }
        public decimal? Loss { get; set; }

        public DateOnly DateFrom { get; set; }
        public DateOnly? DateTo { get; set; }

        public int CompanyId { get; set; }

        public bool IsCurrentlyActive => DateOnly.FromDateTime(DateTime.Now) >= DateFrom
            && (!DateTo.HasValue || DateOnly.FromDateTime(DateTime.Now) <= DateTo);

        public int EntityId => Id;
        public EntityType EntityType => EntityType.Recipe;
        public string DisplayValue => "";
    }
}
