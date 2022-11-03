using System;
using Core.Models.EfModels.Base;
using Core.Models.EfModels.Documents;

namespace Core.Models.EfModels
{
    public class TransportInfo : DatabaseEntity<int>
    {
        public Guid DocumentId { get; set; }
        public Document Document { get; set; }

        public decimal? TankChamberQuantity { get; set; }
        public decimal? SealNumberPerChamber { get; set; }
        public decimal? SealNumberPerFuellingPoint { get; set; }

        public int CompanyId { get; set; }
        public Company Company { get; set; }
    }
}