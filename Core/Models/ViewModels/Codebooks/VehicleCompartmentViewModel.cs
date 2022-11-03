using Core.Models.ViewModels.Codebooks.Base;

namespace Core.Models.ViewModels.Codebooks
{
    public class VehicleCompartmentViewModel : CodebookBaseViewModel
    {
        public int VehicleId { get; set; }

        public decimal Volume { get; set; }
    }
}
