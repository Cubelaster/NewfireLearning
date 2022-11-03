using Core.Enums;

namespace Core.Models.Requests.Document
{
    public class DocumentComprehensiveInvoiceCreateRequest : DocumentCreateRequest
    {
        public ComprehensiveInvoiceCreateModeEnum CreateMode { get; set; }
    }
}
