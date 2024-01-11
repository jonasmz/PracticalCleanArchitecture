using Microsoft.Extensions.DependencyInjection;
using NortWind.Sales.BusinessObjects.Interfaces.Ports;
using NortWind.Sales.UseCases.CreateOrder;

namespace NortWind.Sales.UseCases
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddUseCasesServices(this IServiceCollection services){
            services.AddScoped<ICreateOrderInputPort, CreateOrderInteractor>();
            
            return services;
        }
    }
}