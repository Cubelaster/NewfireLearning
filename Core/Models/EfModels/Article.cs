using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Core.Models.EfModels.Base;
using Core.Models.EfModels.Codebooks;
using Core.Models.EfModels.Documents;
using Core.Models.EfModels.EntityConnectors;
using Core.Models.EfModels.Partners;
using Core.Models.EfModels.Promotions;

namespace Core.Models.EfModels
{
    public class Article : DatabaseEntityTranslated<int>
    {
        [Required, StringLength(40)]
        public string Code { get; set; }

        public int ArticleTypeId { get; set; }
        public ArticleType ArticleType { get; set; }

        [StringLength(22)]
        public string NameShort { get; set; }

        public int UnitOfMeasureId { get; set; }
        public UnitOfMeasure UnitOfMeasure { get; set; }

        public decimal Quantity { get; set; }
        public int UnitOfMeasureQuantitativeId { get; set; }
        public UnitOfMeasure UnitOfMeasureQuantitative { get; set; }
        public decimal? DepositRefund { get; set; }

        public int ArticleCategoryId { get; set; }
        public ArticleCategory ArticleCategory { get; set; }

        public bool IsActive { get; set; }

        public int CompanyId { get; set; }
        public Company Company { get; set; }

        public List<Barcode> Barcodes { get; set; }
        public List<ArticleAssortment> Assortments { get; set; }
        public List<ArticleTaxType> TaxTypes { get; set; }
        public List<PurchasePrice> PurchasePrices { get; set; }
        public List<SalesPrice> SalesPrices { get; set; }
        public List<CustomerPrice> CustomerPrices { get; set; }
        public List<Recipe> ProductRecipes { get; set; }
        public List<Recipe> ComponentRecipes { get; set; }
        public List<ArticleAdditionalTax> AdditionalTaxes { get; set; }

        public IEnumerable<DocumentItem> DocumentItems { get; set; }

        [NotMapped]
        public IEnumerable<EntityNote> Notes { get; set; }
        [NotMapped]
        public IEnumerable<EntityExternalCode> EntityExternalCodes { get; set; }

        #region Promotions

        public IEnumerable<PromotionAssortmentArticle> PromotionAssortmentArticles { get; set; }
        public IEnumerable<PromotionDiscount> PromotionDiscounts { get; set; }
        public IEnumerable<PromotionCondition> PromotionConditions { get; set; }
        public IEnumerable<PromotionNormative> PromotionNormatives { get; set; }

        #endregion Promotions
    }
}
