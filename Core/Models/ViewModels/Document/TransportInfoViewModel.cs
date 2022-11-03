using System;
using Core.Enums;
using Core.Models.ViewModels.Base;

namespace Core.Models.ViewModels.Document
{
    public class TransportInfoViewModel : IBaseViewModel<int>
    {
        public int Id { get; set; }
        public Guid DocumentId { get; set; }

        public decimal? TankChamberQuantity { get; set; }
        public decimal? SealNumberPerChamber { get; set; }
        public decimal? SealNumberPerFuellingPoint { get; set; }

        public int CompanyId { get; set; }

        public int EntityId => Id;
        public EntityType EntityType => EntityType.TransportInfo;
        public string DisplayValue => "";
    }
}
