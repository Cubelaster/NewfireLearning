using System.Collections.Generic;
using Core.Models.Requests.Base;

namespace Core.Models.Requests.Codebooks
{
    public class VehicleUpdateRequest : VehicleCreateRequest, IBaseUpdateRequest<int>
    {
        public int? Id { get; set; }

        public new List<VehicleCompartmentUpdateRequest> Compartments { get; set; }
    }
}
