using System.ComponentModel.DataAnnotations;
using Core.Models.Requests.Base;
using Core.Models.Requests.Codebooks.Base;

namespace Core.Models.Requests.Codebooks
{
    public class CardTypeUpdateRequest : CardTypeCreateRequest, IBaseUpdateRequest<int>
    {
        [Required]
        public int? Id { get; set; }
    }
}
