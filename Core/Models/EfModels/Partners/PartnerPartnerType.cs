using Core.Models.EfModels.Base;
using Core.Models.EfModels.Codebooks;

namespace Core.Models.EfModels.Partners
{
    public class PartnerPartnerType : DatabaseEntity<int>
    {
        public int PartnerId { get; set; }
        public Partner Partner { get; set; }

        public int PartnerTypeId { get; set; }
        public PartnerType PartnerType { get; set; }
    }
}
