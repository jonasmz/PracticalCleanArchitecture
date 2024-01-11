
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Nortwind.EFCore.Repositories.DataContexts;
using Nortwind.EFCore.Repositories.Repositories;
using NortWind.Sales.BusinessObjects.Interfaces.Repositories;

namespace Nortwind.EFCore.Repositories
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddEFRepositories(
            this IServiceCollection services,
            IConfiguration configuration,
            string connectionStringName
        ){
            var connectionString = configuration.GetConnectionString(connectionStringName);
            services.AddDbContext<NorthWindSalesContext>( options => 
                options.UseSqlite(connectionString)
            );
            
            services.AddScoped<INorthWindSalesCommandsRepository, NorthWindSalesCommandsRepository>();
            return services;
        } 
    }
}