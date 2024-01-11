using Microsoft.Extensions.DependencyInjection;
using NortWind.Sales.BusinessObjects.Interfaces.Controllers;

namespace NortWind.Sales.Controllers
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddControllers( this IServiceCollection services){
            services.AddScoped<ICreateOrderController, CreateOrderController>();
            return services;
        }
    }
}