using Core.Enums;
using Core.Models.ViewModels.Base;

namespace Core.Models.ViewModels.ApplicationAction
{
    public class AuditLogViewModel : IBaseViewModel<int>
    {
        public int Id { get; set; }

        public int? ApplicationActionId { get; set; }

        public string Changes { get; set; }
        public string TableName { get; set; }
        public string State { get; set; }

        public int EntityId => Id;
        public EntityType EntityType => EntityType.AuditLog;
        public string DisplayValue => $"{TableName}: {State}";
    }
}
