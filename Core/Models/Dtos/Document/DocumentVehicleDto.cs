using System;
using Core.Models.ViewModels.Codebooks;

namespace Core.Models.Dtos.Document
{
    public class DocumentVehicleDto
    {
        public int? Id { get; set; }
        public Guid DocumentId { get; set; }
        public int VehicleId { get; set; }
        public VehicleBaseViewModel Vehicle { get; set; }
    }
}
