using Core.Models.ViewModels.Codebooks.Base;

namespace Core.Models.ViewModels.Codebooks
{
    public class VehicleBaseViewModel : CodebookBaseViewModel
    {
        public string RegistrationPlate { get; set; }
        public decimal Volume { get; set; }

        public int TransporterId { get; set; }

        public override string DisplayValue => $"{Code}-{RegistrationPlate}";
    }
}
