using NortWind.Sales.BusinessObjects.DTOs.CreateOrder;
using NortWind.Sales.BusinessObjects.Interfaces.Controllers;

namespace NorthWind.Sales.WebApi
{
    public static class EndPoints
    {
        public static WebApplication UseNorthWindSalesEndPoints( this WebApplication app){
            app.MapPost("/create", 
                async(CreateOrderDTO order, 
                ICreateOrderController controller) => Results.Ok(await controller.CreateOrder(order))
            );

            return app;
        }
        
    }
}