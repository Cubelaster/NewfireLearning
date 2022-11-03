using System;
using Core.Models.EfModels.Base;
using Core.Models.EfModels.Codebooks;

namespace Core.Models.EfModels.Documents
{
    public class DocumentVehicle : DatabaseEntity<int>
    {
        public Guid DocumentId { get; set; }
        public Document Document { get; set; }

        public int VehicleId { get; set; }
        public Vehicle Vehicle { get; set; }
    }
}
