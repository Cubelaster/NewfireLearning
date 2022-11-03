using System;
using Core.Models.ViewModels.Codebooks;

namespace Core.Models.Dtos.Document
{
    public class DocumentFuelAnalysisDto
    {
        public int? Id { get; set; }

        public Guid DocumentId { get; set; }

        public int AnalysisTypeId { get; set; }
        public AnalysisTypeViewModel AnalysisType { get; set; }

        public string Value { get; set; }
    }
}
