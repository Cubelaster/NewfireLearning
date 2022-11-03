using System.Collections.Generic;
using Core.Enums;
using Core.Models.Utility;

namespace Core.Models.Dtos.EntityConnectors.MetaMaterializations
{
    public record DocumentTypeMetaDto
    {
        public bool HasUniqueView { get; set; }
        public bool EnforcesUniqueFormAccess { get; set; }

        public bool IsBoundToSite { get; set; } = true;
        public bool CopyPartnerNotesOnNew { get; set; }

        public bool AllowNegativeQuantity { get; set; }
        /// <summary>
        /// This one was added because loading both Purchase and Sales Prices
        /// Enables calculation of margins and stuff, which we don't want
        /// So this one effectively enables us to stop it
        /// </summary>
        public bool DocuItemsHavePurchasePrices { get; set; }
        public bool HasParticipants { get; set; }
        public bool HasAdditionalFuelNotes { get; set; }
        public bool HasFuelAnalysis { get; set; }
        public bool HasDependentCosts { get; set; }
        public bool HasTransportInfos { get; set; }
        public bool HasVehicles { get; set; }
        public bool HasCustomsData { get; set; }
        public bool HasAdditionalTaxes { get; set; }
        public bool HasPayments { get; set; }
        public bool LoadsCustomerPrices { get; set; }

        public List<FieldConfig> FormFields { get; set; }
        /// <summary>
        /// All the statuses available for that DocumentType
        /// The first one is also initial
        /// </summary>
        public List<DocumentStatusEnum> AvailableStatuses { get; set; }
    }
}
