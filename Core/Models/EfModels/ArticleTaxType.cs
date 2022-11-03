using System;
using Core.Models.EfModels.Base;
using Core.Models.EfModels.Codebooks;

namespace Core.Models.EfModels
{
    public class ArticleTaxType : DatabaseEntity<int>
    {
        public int ArticleId { get; set; }
        public Article Article { get; set; }

        public int TaxTypeId { get; set; }
        public TaxType TaxType { get; set; }

        public DateOnly DateFrom { get; set; }
        public DateOnly? DateTo { get; set; }
    }
}
