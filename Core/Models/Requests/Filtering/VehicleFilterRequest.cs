using ReFilter.Models;

namespace Core.Models.Requests.Filtering
{
    public class VehicleFilterRequest : CodebooksBaseFilterRequest
    {
        public int? TransporterId { get; set; }
        public string RegistrationPlate { get; set; }
        public RangeFilter<decimal> Volume { get; set; }
    }
}
