using Core.Enums;
using Core.Models.Utility;
using Core.Models.ViewModels.Base;

namespace Core.Models.ViewModels.Codebooks.Base
{
    public class CodebookBaseViewModel : IBaseViewModel<int>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public int CompanyId { get; set; }

        public int? AppCodeId { get; set; }
        public AppCodeViewModel AppCode { get; set; }

        public Translations Translations { get; set; }

        public EntityType CodebookEntityType { get; set; }

        public int EntityId => Id;
        public EntityType EntityType => CodebookEntityType;
        public virtual string DisplayValue => $"{Code}-{Name}";
    }
}
