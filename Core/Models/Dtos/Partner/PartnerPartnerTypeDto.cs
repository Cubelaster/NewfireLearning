using Core.Models.ViewModels.Codebooks.Base;

namespace Core.Models.Dtos.Partner
{
    public class PartnerPartnerTypeDto
    {
        public int? Id { get; set; }
        public int PartnerId { get; set; }
        public int PartnerTypeId { get; set; }
        public CodebookBaseViewModel PartnerType { get; set; }
    }
}
