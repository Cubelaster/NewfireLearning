using System.Collections.Generic;
using Core.Models.ViewModels.Partner;

namespace Core.Models.ViewModels.Codebooks
{
    public class VehicleDetailViewModel : VehicleBaseViewModel
    {
        public PartnerBaseViewModel Transporter { get; set; }
        public List<VehicleCompartmentViewModel> Compartments { get; set; }
    }
}
