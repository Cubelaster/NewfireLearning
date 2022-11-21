namespace Cards.API.Models
{
    public class Card 
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime DueDate { get; set; }
        public bool IsComplete { get; set; }
        public int BoardId { get; set; }
        
    }
}
