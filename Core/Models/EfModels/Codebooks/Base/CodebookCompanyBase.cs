namespace Core.Models.EfModels.Codebooks.Base
{
    public class CodebookCompanyBase : CodebookBase
    {
        public int CompanyId { get; set; }
        public Company Company { get; set; }
    }
}
