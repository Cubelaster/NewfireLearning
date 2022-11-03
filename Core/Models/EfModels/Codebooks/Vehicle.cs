using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Core.Models.EfModels.Codebooks.Base;
using Core.Models.EfModels.Documents;
using Core.Models.EfModels.Partners;
using ReFilter.Attributes;

namespace Core.Models.EfModels.Codebooks
{
    public class Vehicle : CodebookCompanyBase
    {
        [ReFilterProperty(UsedForSearchQuery = true)]
        [StringLength(60), Required]
        public string RegistrationPlate { get; set; }
        public decimal Volume { get; set; }

        public int AppCodeId { get; set; }
        public AppCode AppCode { get; set; }

        public int TransporterId { get; set; }
        public Partner Transporter { get; set; }

        public List<VehicleCompartment> Compartments { get; set; }
        public IEnumerable<DocumentVehicle> DocumentVehicles { get; set; }
    }
}
