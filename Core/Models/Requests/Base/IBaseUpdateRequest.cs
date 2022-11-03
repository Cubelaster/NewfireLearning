using System.ComponentModel.DataAnnotations;

namespace Core.Models.Requests.Base
{
    public interface IBaseUpdateRequest<U> where U : struct
    {
        [Required]
        public U? Id { get; set; }
    }
}
