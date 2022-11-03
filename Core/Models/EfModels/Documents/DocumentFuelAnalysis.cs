using System;
using System.ComponentModel.DataAnnotations;
using Core.Models.EfModels.Base;

namespace Core.Models.EfModels.Documents
{
    public class DocumentFuelAnalysis : DatabaseEntity<int>
    {
        public Guid DocumentId { get; set; }
        public Document Document { get; set; }

        public int AnalysisTypeId { get; set; }
        public AnalysisType AnalysisType { get; set; }

        [Required, StringLength(400)]
        public string Value { get; set; }
    }
}
