using Core.Enums;
using Core.Models.ViewModels.Base;

namespace Core.Models.ViewModels.Partner
{
    public class PartnerBaseViewModel : IBaseViewModel<int>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public int CompanyId { get; set; }

        public int EntityId => Id;
        public EntityType EntityType => EntityType.Partner;
        public string DisplayValue => $"{Code}-{Name}";
    }
}
