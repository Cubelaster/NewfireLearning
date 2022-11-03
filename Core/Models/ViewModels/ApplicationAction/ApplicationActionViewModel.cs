using System;
using Core.Enums;
using Core.Models.ViewModels.Base;
using Core.Models.ViewModels.User;

namespace Core.Models.ViewModels.ApplicationAction
{
    public class ApplicationActionViewModel : IBaseViewModel<int>
    {
        public int Id { get; set; }

        public int ApplicationActionDefinitionId { get; set; }

        public int? ParentActionId { get; set; }

        public string Request { get; set; }
        public string Response { get; set; }
        public DateTime ActionStartTime { get; set; }
        public DateTime? ActionEndTime { get; set; }
        public string ActionResult { get; set; }

        public DateTime DateCreated { get; set; }
        public DateTime? DateModified { get; set; }

        public Guid? CreatedById { get; set; }
        public UserBaseViewModel CreatedBy { get; set; }
        public UserBaseViewModel LastModifiedBy { get; set; }

        public int EntityId => Id;
        public EntityType EntityType => EntityType.ApplicationAction;
        public string DisplayValue => $"{ActionStartTime} - {ActionEndTime} : {ActionResult}";
    }
}
