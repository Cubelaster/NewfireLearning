using System.Collections.Generic;
using Core.Models.EfModels.Codebooks.Base;
using Core.Models.EfModels.Documents;

namespace Core.Models.EfModels.Codebooks
{
    public class UnitOfMeasure : CodebookCompanyBase
    {
        public IEnumerable<Article> Articles { get; set; }
        public IEnumerable<Article> ArticlesQuantitative { get; set; }
        public IEnumerable<Barcode> Barcodes { get; set; }
        public IEnumerable<DocumentItem> DocumentItems { get; set; }
        public IEnumerable<Recipe> Recipes { get; set; }
    }
}
