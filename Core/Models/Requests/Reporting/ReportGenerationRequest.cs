using System.Net.Mime;

namespace Core.Models.Requests.Reporting
{
    public class ReportGenerationRequest
    {
        public string FileName { get; set; }
        public string MediaType { get; set; } = MediaTypeNames.Application.Pdf;
        public string ReportName { get; set; }
        public string ReportPath { get; set; }
        public string ReportParams { get; set; }
    }
}
