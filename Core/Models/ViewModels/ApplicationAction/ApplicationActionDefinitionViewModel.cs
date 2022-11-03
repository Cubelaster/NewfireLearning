using System;
using Core.Enums;
using Core.Models.ViewModels.Base;
using Core.Models.ViewModels.User;

namespace Core.Models.ViewModels.ApplicationAction
{
    public class ApplicationActionDefinitionViewModel : IBaseViewModel<int>
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string ActionOwnerName { get; set; }
        public string ActionName { get; set; }
        public string RequestSignature { get; set; }
        public string ResponseSignature { get; set; }

        public DateTime DateCreated { get; set; }
        public DateTime? DateModified { get; set; }
        public DatabaseEntityStatus IsDeleted { get; set; }

        public Guid CreatedById { get; set; }
        public UserBaseViewModel CreatedBy { get; set; }
        public Guid? LastModifiedById { get; set; }
        public UserBaseViewModel LastModifiedBy { get; set; }

        public bool IsActive => IsDeleted == DatabaseEntityStatus.Active;

        public int EntityId => Id;
        public EntityType EntityType => EntityType.ApplicationActionDefinition;
        public string DisplayValue => $"{ActionOwnerName}:{ActionName}";
    }
}
