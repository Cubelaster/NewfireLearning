using System.Net;

namespace Core.Models.Utility.Configuration
{
    public class ReportingServicesConfig
    {
        public string HttpClientName { get; set; }
        public string BaseUrl { get; set; }
        public string ReportsUrlSegment { get; set; }
        public string ReportParamsUrlSegment { get; set; }
        public string ReportsViewerUrlSegment { get; set; }
        public NetworkCredential NetworkCredential { get; set; }
    }
}
