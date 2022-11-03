using System;
using Core.Enums;
using Core.Models.ViewModels.Base;

namespace Core.Models.ViewModels.Role
{
    public class RoleViewModel : IBaseViewModel<Guid>
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int CompanyId { get; set; }

        public Guid EntityId => Id;
        public EntityType EntityType => EntityType.Role;
        public string DisplayValue => Name;
    }
}
