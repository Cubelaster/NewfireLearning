using System;
using Core.Enums;
using Core.Models.ViewModels.Base;
using Core.Models.ViewModels.Codebooks;
using Core.Models.ViewModels.FiscalYear;
using Core.Models.ViewModels.Site;

namespace Core.Models.ViewModels.Document
{
    public class DocumentBaseViewModel : IBaseViewModel<Guid>
    {
        public Guid Id { get; set; }

        public Guid? HeadDocumentId { get; set; }
        public Guid? OriginalId { get; set; }

        public int FiscalYearId { get; set; }
        public FiscalYearViewModel FiscalYear { get; set; }
        public int Year { get; set; }

        public int Number { get; set; }

        public SiteBaseViewModel Site { get; set; }

        public DocumentTypeViewModel Type { get; set; }
        public DocumentStatusViewModel Status { get; set; }

        public DateOnly Date { get; set; }
        public DateTime? ConfirmationDate { get; set; }

        public CurrencyViewModel Currency { get; set; }

        public int CompanyId { get; set; }

        public Guid EntityId => Id;
        public EntityType EntityType => EntityType.Document;
        public string DisplayValue => $"{Number}/{Year}/{Site?.DisplayValue ?? "-"}";
    }
}
