using Core.Models.Requests.Base;

namespace Core.Models.Requests.Reporting
{
    public class StoredProcedureReportParamUpdateRequest : StoredProcedureReportParamCreateRequest, IBaseUpdateRequest<int>
    {
        public int? Id { get; set; }
    }
}
