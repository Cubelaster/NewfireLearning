using Core.Models.Utility;
using Core.Utility;
using Microsoft.EntityFrameworkCore;
using Workspaces.Core.Models.EfModels;
using Workspaces.Infrastructure.Converters;

namespace Workspaces.Infrastructure.EfContext
{
    public class WorkspacesDbContext : DbContext
    {
        public WorkspacesDbContext(DbContextOptions dbContextOptions) : base(dbContextOptions) { }

        #region DbSets

        public DbSet<Workspace> Workspaces { get; set; }

        #endregion DbSets

        protected override void ConfigureConventions(ModelConfigurationBuilder builder)
        {
            builder.Properties<decimal>()
                .HaveColumnType(GlobalVariables.HighPrecisionDecimal);

            builder.Properties<decimal?>()
                .HaveColumnType(GlobalVariables.HighPrecisionDecimal);

            builder.Properties<Translations>()
                .HaveConversion<TranslationsConverter>();

            builder.Properties<DateOnly>()
                .HaveConversion<DateOnlyConverter>()
                .HaveColumnType("date");

            builder.Properties<DateOnly?>()
                .HaveConversion<NullableDateOnlyConverter>()
                .HaveColumnType("date");
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}
