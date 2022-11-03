using System.ComponentModel.DataAnnotations;
using Core.Models.Requests.Base;

namespace Core.Models.Requests.Article
{
    public class BarcodeCreateRequest : BaseRequest
    {
        [Required]
        public string BarCode { get; set; }
        [Required]
        public int? Quantity { get; set; }
        [Required]
        public int? UnitOfMeasureId { get; set; }

        //[Required]
        public int? ArticleId { get; set; }
        [Required]
        public int? CompanyId { get; set; }
    }
}
