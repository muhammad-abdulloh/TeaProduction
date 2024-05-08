using Microsoft.EntityFrameworkCore;
using TeaProduction.Domain.Entities;

namespace TeaProduction.Application.Abstractions
{
    public interface ITeaProductionDbContext
    {
        public DbSet<Tea> Teas { get; set; }

        public Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
