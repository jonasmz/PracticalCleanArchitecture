using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using NorthWind.Sales.Presenters;
using Nortwind.EFCore.Repositories;
using NortWind.Sales.Controllers;
using NortWind.Sales.UseCases;

namespace NorthWind.Sales.IoC
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddNothwindSalesServices( 
            this IServiceCollection services,
            IConfiguration configuration,
            string connectionStringName
        ){
            services
                .AddEFRepositories(configuration, connectionStringName)
                .AddUseCasesServices()
                .AddPresenters()
                .AddControllers();
                
            return services;
        }
    }
}