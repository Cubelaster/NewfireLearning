using System;
using Core.Models.Requests.Base;

namespace Core.Models.Requests.SalesPrice
{
    public class SalesPriceUpdateRequest : SalesPriceCreateRequest, IBaseUpdateRequest<Guid>
    {
        public Guid? Id { get; set; }
    }
}
