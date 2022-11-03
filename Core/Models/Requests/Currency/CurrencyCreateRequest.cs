using System.ComponentModel.DataAnnotations;
using Core.Models.Requests.Base;

namespace Core.Models.Requests.Currency
{
    public class CurrencyCreateRequest : BaseRequest
    {
        public string Name { get; set; }
        public string Code { get; set; }
        public string Number { get; set; }
        public string Symbol { get; set; }
        [Required]
        public int? CompanyId { get; set; }
    }
}
