using System;
using System.ComponentModel.DataAnnotations;
using Core.Models.Requests.Base;

namespace Core.Models.Requests.PurchasePrice
{
    public class PurchasePriceUpdateRequest : PurchasePriceCreateRequest, IBaseUpdateRequest<Guid>
    {
        [Required]
        public Guid? Id { get; set; }
    }
}
