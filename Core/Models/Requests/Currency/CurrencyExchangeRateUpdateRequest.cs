using System.ComponentModel.DataAnnotations;
using Core.Models.Requests.Base;

namespace Core.Models.Requests.Currency
{
    public class CurrencyExchangeRateUpdateRequest : CurrencyExchangeRateCreateRequest, IBaseUpdateRequest<int>
    {
        [Required]
        public int? Id { get; set; }
    }
}
