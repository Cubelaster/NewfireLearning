using Core.Models.Dtos.EntityConnectors.Base;
using Core.Models.ViewModels.Codebooks.Base;

namespace Core.Models.Dtos.EntityConnectors
{
    public class EntityAddressDto : EntityConnectorBaseDto
    {
        //public int? CountryId { get; set; }
        //public CountryViewModel Country { get; set; }

        //public int? PostalCodeId { get; set; }
        //public PostalCodeViewModel PostalCode { get; set; }

        public int AddressTypeId { get; set; }
        public CodebookBaseViewModel AddressType { get; set; }

        public string ValueExtension { get; set; }
        public string Description { get; set; }

        public DateOnly? DateFrom { get; set; }
        public DateOnly? DateTo { get; set; }
    }
}
