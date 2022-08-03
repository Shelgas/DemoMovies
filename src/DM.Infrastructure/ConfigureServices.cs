using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DM.Infrastructure.Persistance;
using Microsoft.EntityFrameworkCore;
using DM.Infrastructure.Persistance.Repository;

namespace DM.Infrastructure
{
    public static class ConfigureServices
    {
        public static IServiceCollection AddInfastructureServices(
            this IServiceCollection services, IConfiguration configuration)
        {
            var connectionString = configuration["DbConnection"];
            services.AddDbContext<DmContext>(options =>
            {
                options.UseNpgsql(configuration.GetConnectionString("Dmdb"));
            });
            services.AddScoped<IRepositoryWrapper, RepositoryWrapper>();
            return services;
        }
    }
}
