using System;
using System.Collections.Generic;
using Core.Models.Requests.Base;

namespace Core.Models.Requests.Document
{
    public class DocumentUpdateRequest : DocumentCreateRequest, IBaseUpdateRequest<Guid>
    {
        public Guid? Id { get; set; }

        public new List<DocumentUpdateRequest> DocumentsAsItems { get; set; }
        public new List<DocumentItemUpdateRequest> Items { get; set; }
        public new List<DependentCostUpdateRequest> DependentCosts { get; set; }
        public new List<AdditionalFuelNoteUpdateRequest> AdditionalFuelNotes { get; set; }
        public new List<TransportInfoUpdateRequest> TransportInfos { get; set; }
        public new List<DocumentPaymentUpdateRequest> Payments { get; set; }
    }
}
