using Core.Models.EfModels.Codebooks.Base;

namespace Core.Models.EfModels.Codebooks
{
    public class VehicleCompartment : CodebookCompanyBase
    {
        public int VehicleId { get; set; }
        public Vehicle Vehicle { get; set; }

        public decimal Volume { get; set; }
    }
}
