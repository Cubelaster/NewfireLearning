using Core.Models.ViewModels.Codebooks.Base;

namespace Core.Models.ViewModels.Codebooks
{
    public class AnalysisTypeViewModel : CodebookBaseViewModel
    {
        public string UnitOfMeasure { get; set; }

        public string Method { get; set; }
    }
}
