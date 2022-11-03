using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Core.Models.EfModels.Base;
using ReFilter.Attributes;

namespace Core.Models.EfModels.Codebooks
{
    public class PostalCode : DatabaseEntityTranslated<int>
    {
        [ReFilterProperty(UsedForSearchQuery = true)]
        [StringLength(40)]
        public string Code { get; set; }

        public int CountryId { get; set; }
        public Country Country { get; set; }

        public int CompanyId { get; set; }
        public Company Company { get; set; }

        public IEnumerable<Site> Sites { get; set; }
        public IEnumerable<Company> Companies { get; set; }
        public IEnumerable<DeliveryPoint> DeliveryPoints { get; set; }
    }
}
