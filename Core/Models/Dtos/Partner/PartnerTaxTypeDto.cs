using System;
using Core.Models.ViewModels.Codebooks;

namespace Core.Models.Dtos.Partner
{
    public class PartnerTaxTypeDto
    {
        public int? Id { get; set; }
        public int PartnerId { get; set; }
        public int TaxTypeId { get; set; }
        public TaxTypeGridViewModel TaxType { get; set; }

        public DateOnly DateFrom { get; set; }
        public DateOnly? DateTo { get; set; }
    }
}
