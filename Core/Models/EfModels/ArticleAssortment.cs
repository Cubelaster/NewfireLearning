using Core.Models.EfModels.Base;

namespace Core.Models.EfModels
{
    public class ArticleAssortment : DatabaseEntity<int>
    {
        public int ArticleId { get; set; }
        public Article Article { get; set; }

        public int AssortmentId { get; set; }
        public Assortment Assortment { get; set; }
    }
}
