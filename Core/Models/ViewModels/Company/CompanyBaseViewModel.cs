using Core.Enums;
using Core.Models.ViewModels.Base;

namespace Core.Models.ViewModels.Company
{
    public class CompanyBaseViewModel : IBaseViewModel<int>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }

        public int EntityId => Id;
        public EntityType EntityType => EntityType.Company;
        public string DisplayValue => Name;
    }
}
