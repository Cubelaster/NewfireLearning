namespace Tasks.API.Models
{
    public class Tasks 
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime DueDate { get; set; }
        public bool IsComplete { get; set; }
        public int WorkspaceId { get; set; }
        
    }
}
