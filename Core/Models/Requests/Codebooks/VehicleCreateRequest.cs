using System.Collections.Generic;
using Core.Models.Requests.Codebooks.Base;

namespace Core.Models.Requests.Codebooks
{
    public class VehicleCreateRequest : CodebookBaseCreateRequest
    {
        public string RegistrationPlate { get; set; }
        public decimal Volume { get; set; }

        public int TransporterId { get; set; }

        public List<VehicleCompartmentCreateRequest> Compartments { get; set; }
    }
}
