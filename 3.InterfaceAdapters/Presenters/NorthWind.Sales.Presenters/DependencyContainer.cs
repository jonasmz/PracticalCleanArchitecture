using Microsoft.Extensions.DependencyInjection;
using NortWind.Sales.BusinessObjects.Interfaces.Ports;
using NortWind.Sales.BusinessObjects.Interfaces.Presenters;

namespace NorthWind.Sales.Presenters
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddPresenters(this IServiceCollection services){
            
            services.AddScoped<CreateOrderPresenter>();
            services.AddScoped<ICreateOrderPresenter>(provider => 
                provider.GetService<CreateOrderPresenter>());
            services.AddScoped<ICreateOrderOutputPort>(provider => 
                provider.GetService<CreateOrderPresenter>());
            
            return services;
        }
    }
}