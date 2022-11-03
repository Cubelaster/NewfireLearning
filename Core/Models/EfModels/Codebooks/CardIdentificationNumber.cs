using System.ComponentModel.DataAnnotations;
using Core.Models.EfModels.Base;

namespace Core.Models.EfModels.Codebooks
{
    public class CardIdentificationNumber : DatabaseEntity<int>
    {
        [StringLength(20), Required]
        public string Number { get; set; }

        public int RangeId { get; set; }
        public CardIdentificationNumberRange Range { get; set; }

        public int CompanyId { get; set; }
        public Company Company { get; set; }
    }
}
