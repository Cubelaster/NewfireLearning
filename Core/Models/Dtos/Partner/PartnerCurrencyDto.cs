using System;
using Core.Models.ViewModels.Codebooks;

namespace Core.Models.Dtos.Partner
{
    public class PartnerCurrencyDto
    {
        public int? Id { get; set; }
        public int PartnerId { get; set; }
        public int CurrencyId { get; set; }
        public CurrencyViewModel Currency { get; set; }
        public DateOnly DateFrom { get; set; }
        public DateOnly? DateTo { get; set; }
    }
}
