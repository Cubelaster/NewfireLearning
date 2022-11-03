using System;
using System.ComponentModel.DataAnnotations;
using Core.Models.Requests.Base;

namespace Core.Models.Requests.User
{
    public class UserUpdateRequest : UserCreateRequest, IBaseUpdateRequest<Guid>
    {
        [Required]
        public Guid? Id { get; set; }
    }
}
