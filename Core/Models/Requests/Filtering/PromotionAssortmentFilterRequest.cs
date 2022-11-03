namespace Core.Models.Requests.Filtering
{
    public class PromotionAssortmentFilterRequest : CodebooksBaseFilterRequest
    {
        public bool? IsActive { get; set; }
    }
}
