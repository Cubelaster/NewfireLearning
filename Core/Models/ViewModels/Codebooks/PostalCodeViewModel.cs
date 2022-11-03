using Core.Enums;
using Core.Models.Utility;
using Core.Models.ViewModels.Base;

namespace Core.Models.ViewModels.Codebooks
{
    public class PostalCodeViewModel : IBaseViewModel<int>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public int CountryId { get; set; }
        public CountryViewModel Country { get; set; }
        public int CompanyId { get; set; }

        public Translations Translations { get; set; }

        public int EntityId => Id;
        public EntityType EntityType => EntityType.PostalCode;
        public string DisplayValue => $"{Code}-{Name}";
    }
}
