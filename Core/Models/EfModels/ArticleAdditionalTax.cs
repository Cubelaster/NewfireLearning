using System;
using Core.Models.EfModels.Base;
using Core.Models.EfModels.Codebooks;

namespace Core.Models.EfModels
{
    public class ArticleAdditionalTax : DatabaseEntity<int>
    {
        public int ArticleId { get; set; }
        public Article Article { get; set; }

        public int AdditionalTaxId { get; set; }
        public AdditionalTax AdditionalTax { get; set; }

        public DateOnly DateFrom { get; set; }
        public DateOnly? DateTo { get; set; }
    }
}
