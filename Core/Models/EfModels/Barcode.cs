using System.ComponentModel.DataAnnotations;
using Core.Models.EfModels.Base;
using Core.Models.EfModels.Codebooks;
using ReFilter.Attributes;

namespace Core.Models.EfModels
{
    public class Barcode : DatabaseEntity<int>
    {
        [ReFilterProperty(UsedForSearchQuery = true)]
        [Required, StringLength(255)]
        public string BarCode { get; set; }

        public int Quantity { get; set; }

        public int UnitOfMeasureId { get; set; }
        public UnitOfMeasure UnitOfMeasure { get; set; }

        public int ArticleId { get; set; }
        public Article Article { get; set; }

        public int CompanyId { get; set; }
        public Company Company { get; set; }
    }
}
