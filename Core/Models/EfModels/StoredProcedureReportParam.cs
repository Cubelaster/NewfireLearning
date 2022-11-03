using System.ComponentModel.DataAnnotations;
using Core.Enums;
using Core.Models.EfModels.Base;

namespace Core.Models.EfModels
{
    public class StoredProcedureReportParam : DatabaseEntityTranslated<int>
    {
        public int StoredProcedureReportId { get; set; }
        public StoredProcedureReport StoredProcedureReport { get; set; }

        [StringLength(20)]
        public string Argument { get; set; }
        public ReportingServiceParameterTypeEnum Type { get; set; }
        public bool IsDropDown { get; set; }
        public bool IsMultiSelect { get; set; }
        public EntityType? DropDownEntityType { get; set; }

        public int CompanyId { get; set; }
        public Company Company { get; set; }
    }
}
