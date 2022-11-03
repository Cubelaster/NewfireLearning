using Core.Models.ViewModels.Codebooks.Base;
using Core.Models.ViewModels.Commercialist;

namespace Core.Models.ViewModels.Partner
{
    public class PartnerGridViewModel : PartnerBaseViewModel
    {
        public string CodeExternal { get; set; }
        public string NameAdditional { get; set; }

        public string PibOib { get; set; }
        public string MBR { get; set; }

        public CommercialistViewModel Commercialist { get; set; }
        public CodebookBaseViewModel SiteRegion { get; set; }
        public CodebookBaseViewModel PrintType { get; set; }
    }
}
