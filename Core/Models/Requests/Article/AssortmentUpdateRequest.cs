using System.ComponentModel.DataAnnotations;
using Core.Models.Requests.Base;

namespace Core.Models.Requests.Article
{
    public class AssortmentUpdateRequest : AssortmentCreateRequest, IBaseUpdateRequest<int>
    {
        [Required]
        public int? Id { get; set; }
    }
}
