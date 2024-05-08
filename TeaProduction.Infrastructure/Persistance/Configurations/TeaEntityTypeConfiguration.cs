using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TeaProduction.Domain.Entities;

namespace TeaProduction.Infrastructure.Persistance.Configurations
{
    public class TeaEntityTypeConfiguration : IEntityTypeConfiguration<Tea>
    {
        public void Configure(EntityTypeBuilder<Tea> builder)
        {
            builder.HasKey(t => t.Id);

            builder.HasQueryFilter(x => x.IsDeleted != true);
        }
    }
}
