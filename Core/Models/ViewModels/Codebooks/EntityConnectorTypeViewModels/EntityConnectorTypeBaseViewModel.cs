using Core.Enums;
using Core.Models.Utility;
using Core.Models.ViewModels.Base;

namespace Core.Models.ViewModels.Codebooks.EntityConnectorTypeViewModels
{
    public class EntityConnectorTypeBaseViewModel : IBaseViewModel<int>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }

        public Translations Translations { get; set; }

        public EntityType CodebookEntityType { get; set; }

        public int EntityId => Id;
        public EntityType EntityType => CodebookEntityType;
        public string DisplayValue => $"{Code}-{Name}";
    }
}
