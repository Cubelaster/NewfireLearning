using System;
using Core.Models.Requests.Base;

namespace Core.Models.Requests.Document
{
    public class AdditionalFuelNoteCreateRequest : BaseRequest
    {
        public Guid DocumentId { get; set; }

        public string Value { get; set; }

        public int AdditionalFuelNoteTypeId { get; set; }

        public int CompanyId { get; set; }
    }
}
