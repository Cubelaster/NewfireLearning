using Core.Models.EfModels.Base;

namespace Cards.API.Models
{
    public class Card : DatabaseEntity<Int32>
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime DueDate { get; set; }
        public bool IsComplete { get; set; }
        public int BoardId { get; set; }
        
    }
}
