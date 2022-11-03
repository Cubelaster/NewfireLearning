using Core.Enums;
using Core.Models.ViewModels.Base;

namespace Core.Models.ViewModels.Commercialist
{
    public class CommercialistViewModel : IBaseViewModel<int>
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Code { get; set; }

        public string Email { get; set; }
        public string Phone { get; set; }
        public string MobilePhone { get; set; }

        public int CompanyId { get; set; }

        public int EntityId => Id;
        public EntityType EntityType => EntityType.Commercialist;
        public string DisplayValue => $"{Code}-{Name}";
    }
}
