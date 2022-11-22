using Microsoft.EntityFrameworkCore;


namespace Cards.Infrastructure.EfContext
{
    public class CardsContext : DbContext
    {
        public CardsContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Cards.Core.Models.Card> Cards { get; set; }
    }
}
