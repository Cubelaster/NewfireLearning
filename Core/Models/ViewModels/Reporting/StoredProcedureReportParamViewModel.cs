using Core.Enums;
using Core.Models.Utility;
using Core.Models.ViewModels.Base;

namespace Core.Models.ViewModels.Reporting
{
    public class StoredProcedureReportParamViewModel : IBaseViewModel<int>
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Translations Translations { get; set; }

        public int StoredProcedureReportId { get; set; }

        public string Argument { get; set; }
        public ReportingServiceParameterTypeEnum Type { get; set; }
        public bool IsDropDown { get; set; }
        public bool IsMultiSelect { get; set; }
        public EntityType? DropDownEntityType { get; set; }

        public int CompanyId { get; set; }

        public int EntityId => Id;
        public EntityType EntityType => EntityType.StoredProcedureReportParam;
        public string DisplayValue => Name;
    }
}
