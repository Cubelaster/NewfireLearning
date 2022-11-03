using System.ComponentModel.DataAnnotations;
using Core.Models.Requests.Base;

namespace Core.Models.Requests.DecimalPlacesSettings
{
    public class DecimalPlacesSettingsUpdateRequest : DecimalPlacesSettingsCreateRequest, IBaseUpdateRequest<int>
    {
        [Required]
        public int? Id { get; set; }
    }
}
