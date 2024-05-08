using Microsoft.EntityFrameworkCore;
using TeaProduction.Application.Abstractions;
using TeaProduction.Domain.Entities;
using TeaProduction.Infrastructure.Persistance.Configurations;

namespace TeaProduction.Infrastructure.Persistance
{
    public class TeaProductionDbContext : DbContext, ITeaProductionDbContext
    {
        public TeaProductionDbContext(DbContextOptions<TeaProductionDbContext> options)
            : base(options)
        {

        }
        public DbSet<Tea> Teas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new TeaEntityTypeConfiguration());
        }
    }
}
