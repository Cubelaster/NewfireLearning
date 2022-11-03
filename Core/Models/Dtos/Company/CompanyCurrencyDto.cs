using Core.Models.ViewModels.Codebooks;

namespace Core.Models.Dtos.Company
{
    public class CompanyCurrencyDto
    {
        public int? Id { get; set; }
        public int CompanyId { get; set; }
        public int CurrencyId { get; set; }
        public CurrencyViewModel? Currency { get; set; }
        public DateOnly DateFrom { get; set; }
        public DateOnly? DateTo { get; set; }
    }
}
