using Core.Enums;
using Core.Models.ViewModels.Base;
using Core.Models.ViewModels.Codebooks.Base;

namespace Core.Models.ViewModels.Article
{
    public class BarcodeViewModel : IBaseViewModel<int>
    {
        public int Id { get; set; }
        public string BarCode { get; set; }

        public int Quantity { get; set; }

        public int UnitOfMeasureId { get; set; }
        public CodebookBaseViewModel UnitOfMeasure { get; set; }

        public int ArticleId { get; set; }
        public int CompanyId { get; set; }

        public int EntityId => Id;
        public EntityType EntityType => EntityType.Barcode;
        public string DisplayValue => BarCode;
    }
}
