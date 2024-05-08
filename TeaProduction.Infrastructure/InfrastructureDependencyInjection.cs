using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using TeaProduction.Application.Abstractions;
using TeaProduction.Infrastructure.Persistance;

namespace TeaProduction.Infrastructure
{
    public static class InfrastructureDependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ITeaProductionDbContext, TeaProductionDbContext>(options =>
            {
                options.UseNpgsql(configuration.GetConnectionString("TeaProductionConnectionString"));
            });

            return services;
        }
    }
}
