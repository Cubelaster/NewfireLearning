using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Core.Models.EfModels.Base;
using Core.Models.EfModels.Codebooks;
using Core.Models.EfModels.Partners;

namespace Core.Models.EfModels.Documents
{
    public class DocumentItem : DatabaseEntity<Guid>
    {
        public Guid DocumentId { get; set; }
        public Document Document { get; set; }

        public Guid? OriginalId { get; set; }
        public DocumentItem Original { get; set; }

        public int SiteId { get; set; }
        public Site Site { get; set; }

        public int Year { get; set; }
        public int OrdinalNumber { get; set; }

        public int ArticleId { get; set; }
        public Article Article { get; set; }
        [StringLength(255)]
        public string ArticleName { get; set; }

        public int TaxTypeId { get; set; }
        public TaxType TaxType { get; set; }
        public decimal TaxPercentage { get; set; }

        public decimal Quantity { get; set; }

        public int UnitOfMeasureId { get; set; }
        public UnitOfMeasure UnitOfMeasure { get; set; }
        public decimal QuantityUoM { get; set; }

        public int? PartnerId { get; set; }
        public Partner Partner { get; set; }

        public int? PaymentGroupId { get; set; }
        public AppCode PaymentGroup { get; set; }

        #region Purchase Prices

        public decimal? PurchasePrice { get; set; }
        public decimal? PurchasePriceTotal { get; set; }

        public decimal? PurchasePriceExciseDuty { get; set; }
        public decimal? PurchasePriceTaxesAmount { get; set; }
        public decimal? PurchasePriceTaxesAmountTotal { get; set; }

        public decimal? RebatePercentage { get; set; }
        public decimal? RebateAmount { get; set; }
        public decimal? RebateAmountTotal { get; set; }

        public decimal? PurchasePriceNet { get; set; }
        public decimal? PurchasePriceNetTotal { get; set; }

        public decimal? PurchasePriceNetExciseDuty { get; set; }
        public decimal? PurchasePriceNetExciseDutyTotal { get; set; }

        public decimal? PurchasePriceNetExciseDutyTaxAmount { get; set; }
        public decimal? PurchasePriceNetExciseDutyTaxAmountTotal { get; set; }

        public decimal? PurchasePriceNetExciseDutyTax { get; set; }
        public decimal? PurchasePriceNetExciseDutyTaxTotal { get; set; }

        #endregion Purchase Prices

        #region Sales Prices

        public decimal? SalesPriceNet { get; set; }
        public decimal? SalesPriceNetTotal { get; set; }

        public decimal? SalesPriceDiscountPercentage { get; set; }
        public decimal? SalesPriceDiscountAmount { get; set; }
        public decimal? SalesPriceDiscountAmountTotal { get; set; }

        public decimal? SalesPriceNetDiscount { get; set; }
        public decimal? SalesPriceNetDiscountTotal { get; set; }

        public decimal? SalesPriceExciseDuty { get; set; }
        public decimal? SalesPriceExciseDutyTotal { get; set; }

        public decimal? SalesPriceNetExciseDuty { get; set; }
        public decimal? SalesPriceNetExciseDutyTotal { get; set; }

        public decimal? SalesPriceTaxAmount { get; set; }
        public decimal? SalesPriceTaxAmountTotal { get; set; }

        public decimal? SalesPricePackageRefundFee { get; set; }
        public decimal? SalesPricePackageRefundFeeTotal { get; set; }

        public decimal? SalesPrice { get; set; }
        public decimal? SalesPriceTotal { get; set; }

        #endregion Sales Prices

        public decimal? MarginAmount { get; set; }
        public decimal? MarginPercentage { get; set; }
        public decimal? PurchasePriceCost { get; set; }
        public decimal? FeeAmount { get; set; }

        public decimal QuantityOrdered { get; set; }
        public decimal? QuantityATG { get; set; }
        public decimal? QuantityAdditive { get; set; }
        public decimal? QuantityTruckTrailer { get; set; }
        public decimal? QuantityByBook { get; set; }
        public decimal? QuantityDelivered { get; set; }

        public decimal? Height { get; set; }
        public decimal? HeightATG { get; set; }
        public decimal? Temperature { get; set; }
        public decimal? TemperatureATG { get; set; }
        public decimal? Density { get; set; }

        public int CompanyId { get; set; }
        public Company Company { get; set; }

        public List<DocumentItemAdditionalTaxValue> DocumentItemAdditionalTaxValues { get; set; }

        public IEnumerable<DocumentItem> Clones { get; set; }
    }
}
