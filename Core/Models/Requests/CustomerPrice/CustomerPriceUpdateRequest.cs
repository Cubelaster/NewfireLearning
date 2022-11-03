using System;
using Core.Models.Requests.Base;

namespace Core.Models.Requests.CustomerPrice
{
    public class CustomerPriceUpdateRequest : CustomerPriceCreateRequest, IBaseUpdateRequest<Guid>
    {
        public Guid? Id { get; set; }
    }
}
