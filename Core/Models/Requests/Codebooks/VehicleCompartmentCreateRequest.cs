using Core.Models.Requests.Codebooks.Base;

namespace Core.Models.Requests.Codebooks
{
    public class VehicleCompartmentCreateRequest : CodebookBaseCreateRequest
    {
        public int VehicleId { get; set; }
        public decimal Volume { get; set; }
    }
}
