using Microsoft.EntityFrameworkCore;


namespace Tasks.API.Data
{
    public class TasksContext : DbContext
    {
        public TasksContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Tasks.API.Models.Tasks> Tasks { get; set; }
    }
}
