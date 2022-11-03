using System;

namespace Core.Models.Utility.Configuration
{
    public class ApplicationInfo
    {
        public string Version { get; set; }
        public DateTime DeployDate { get; set; }
        public string Branch { get; set; }
        public string Environment { get; set; }
    }
}
