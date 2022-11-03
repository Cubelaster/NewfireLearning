using System;
using Core.Models.Requests.Base;

namespace Core.Models.Requests.FiscalYear
{
    public class FiscalYearCreateRequest : BaseRequest
    {
        public int Year { get; set; }
        public DateOnly DateFrom { get; set; }
        public DateOnly DateTo { get; set; }
        public bool IsLocked { get; set; }

        public int CompanyId { get; set; }
    }
}
