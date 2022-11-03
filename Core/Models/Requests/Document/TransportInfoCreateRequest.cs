using System;
using Core.Models.Requests.Base;

namespace Core.Models.Requests.Document
{
    public class TransportInfoCreateRequest : BaseRequest
    {
        public Guid DocumentId { get; set; }

        public decimal? TankChamberQuantity { get; set; }
        public decimal? SealNumberPerChamber { get; set; }
        public decimal? SealNumberPerFuellingPoint { get; set; }

        public int CompanyId { get; set; }
    }
}
