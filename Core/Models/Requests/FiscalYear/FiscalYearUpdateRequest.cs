using Core.Models.Requests.Base;

namespace Core.Models.Requests.FiscalYear
{
    public class FiscalYearUpdateRequest : FiscalYearCreateRequest, IBaseUpdateRequest<int>
    {
        public int? Id { get; set; }
    }
}
