namespace Core.Models.Requests.Filtering
{
    public class ArticleCategoryFilterRequest : CodebooksBaseFilterRequest
    {
        public int? ParentId { get; set; }
    }
}
