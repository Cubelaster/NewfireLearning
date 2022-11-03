using System;
using System.Collections.Generic;
using Core.Models.Requests.Base;

namespace Core.Models.Requests.Document
{
    public class DocumentItemUpdateRequest : DocumentItemCreateRequest, IBaseUpdateRequest<Guid>
    {
        public Guid? Id { get; set; }

        public new List<DocumentItemAdditionalTaxValueUpdateRequest> DocumentItemAdditionalTaxValues { get; set; }
    }
}
