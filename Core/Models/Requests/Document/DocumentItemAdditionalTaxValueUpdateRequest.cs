using System;
using Core.Models.Requests.Base;

namespace Core.Models.Requests.Document
{
    public class DocumentItemAdditionalTaxValueUpdateRequest : DocumentItemAdditionalTaxValueCreateRequest, IBaseUpdateRequest<Guid>
    {
        public Guid? Id { get; set; }
    }
}
