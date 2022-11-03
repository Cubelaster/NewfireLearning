using Core.Models.Requests.Base;
using Core.Utility;

namespace Core.Models.Requests.Codebooks.ArticleCategory
{
    public class ArticleCategoryTreeModificationRequest : BaseRequest
    {
        public int CompanyId { get; set; }
        public List<TreeNode<ArticleCategoryUpdateRequest>> ArticleCategories { get; set; }
    }
}
