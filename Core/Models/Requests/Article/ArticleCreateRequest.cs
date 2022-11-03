using System.ComponentModel.DataAnnotations;
using Core.Models.Requests.Base;
using Core.Models.Utility;

namespace Core.Models.Requests.Article
{
    public class ArticleCreateRequest : BaseRequest
    {
        public string Name { get; set; }
        public Translations Translations { get; set; }

        [Required]
        public string Code { get; set; }

        public string NameShort { get; set; }

        [Required]
        public int? UnitOfMeasureId { get; set; }
        [Required]
        public decimal? Quantity { get; set; }
        [Required]
        public int? UnitOfMeasureQuantitativeId { get; set; }
        public decimal? DepositRefund { get; set; }

        [Required]
        public int? ArticleTypeId { get; set; }
        [Required]
        public int? ArticleCategoryId { get; set; }

        public bool IsActive { get; set; }

        [Required]
        public int? CompanyId { get; set; }
    }
}
