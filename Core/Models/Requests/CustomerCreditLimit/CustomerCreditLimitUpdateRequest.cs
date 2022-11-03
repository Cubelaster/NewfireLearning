using System;
using Core.Models.Requests.Base;

namespace Core.Models.Requests.CustomerCreditLimit
{
    public class CustomerCreditLimitUpdateRequest : CustomerCreditLimitCreateRequest, IBaseUpdateRequest<Guid>
    {
        public Guid? Id { get; set; }
    }
}
