using Microsoft.EntityFrameworkCore;


namespace Cards.API.Data
{
    public class CardsContext : DbContext
    {
        public CardsContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Cards.API.Models.Card> Cards { get; set; }
    }
}
