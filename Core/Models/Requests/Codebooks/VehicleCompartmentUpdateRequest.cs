using Core.Models.Requests.Base;

namespace Core.Models.Requests.Codebooks
{
    public class VehicleCompartmentUpdateRequest : VehicleCompartmentCreateRequest, IBaseUpdateRequest<int>
    {
        public int? Id { get; set; }
    }
}
