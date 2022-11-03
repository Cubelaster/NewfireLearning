using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Core.Models.EfModels.Codebooks.Base;
using Core.Models.EfModels.Documents;

namespace Core.Models.EfModels
{
    public class AnalysisType : CodebookCompanyBase
    {
        [Required, StringLength(60)]
        public string UnitOfMeasure { get; set; }
        [Required, StringLength(60)]
        public string Method { get; set; }

        public IEnumerable<DocumentFuelAnalysis> DocumentFuelAnalyses { get; set; }
    }
}
