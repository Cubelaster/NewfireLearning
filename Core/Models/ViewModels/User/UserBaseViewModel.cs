using System;
using Core.Enums;
using Core.Models.ViewModels.Base;

namespace Core.Models.ViewModels.User
{
    public class UserBaseViewModel : IBaseViewModel<Guid>
    {
        public Guid Id { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Guid EntityId => Id;
        public EntityType EntityType => EntityType.User;
        public string DisplayValue => $"{FirstName} {LastName}";
    }
}
