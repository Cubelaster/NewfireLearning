using Core.Enums;

namespace Core.Models.Requests.Reporting
{
    public class StoredProcedureReportParamCreateRequest
    {
        public int StoredProcedureReportId { get; set; }

        public string Argument { get; set; }
        public ReportingServiceParameterTypeEnum Type { get; set; }
        public bool IsDropDown { get; set; }
        public bool IsMultiSelect { get; set; }
        public EntityType? DropDownEntityType { get; set; }

        public int CompanyId { get; set; }
    }
}
