using Core.Models.Requests.Base;

namespace Core.Models.Requests.Article
{
    public class RecipeUpdateRequest : RecipeCreateRequest, IBaseUpdateRequest<int>
    {
        public int? Id { get; set; }
    }
}
