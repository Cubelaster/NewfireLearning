using System.ComponentModel.DataAnnotations;
using Core.Models.Requests.Base;

namespace Core.Models.Requests.Codebooks
{
    public class PaymentMethodUpdateRequest : PaymentMethodCreateRequest, IBaseUpdateRequest<int>
    {
        [Required]
        public int? Id { get; set; }
    }
}
