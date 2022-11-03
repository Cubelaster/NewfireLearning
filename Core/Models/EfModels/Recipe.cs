using System;
using Core.Models.EfModels.Base;
using Core.Models.EfModels.Codebooks;

namespace Core.Models.EfModels
{
    public class Recipe : DatabaseEntity<int>
    {
        public int ArticleProductId { get; set; }
        public Article ArticleProduct { get; set; }

        public int ArticleComponentId { get; set; }
        public Article ArticleComponent { get; set; }

        public int UnitOfMeasureId { get; set; }
        public UnitOfMeasure UnitOfMeasure { get; set; }

        public decimal Quantity { get; set; }
        public decimal? Loss { get; set; }

        public DateOnly DateFrom { get; set; }
        public DateOnly? DateTo { get; set; }

        public int CompanyId { get; set; }
        public Company Company { get; set; }
    }
}
