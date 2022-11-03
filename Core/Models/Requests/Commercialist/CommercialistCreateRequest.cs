using System.ComponentModel.DataAnnotations;
using Core.Models.Requests.Base;

namespace Core.Models.Requests.Commercialist
{
    public class CommercialistCreateRequest : BaseRequest
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public int? Code { get; set; }

        public string Email { get; set; }
        public string Phone { get; set; }
        public string MobilePhone { get; set; }

        [Required]
        public int? CompanyId { get; set; }
    }
}
