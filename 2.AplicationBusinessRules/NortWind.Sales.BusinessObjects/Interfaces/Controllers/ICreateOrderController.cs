using NortWind.Sales.BusinessObjects.DTOs.CreateOrder;

namespace NortWind.Sales.BusinessObjects.Interfaces.Controllers
{
    public interface ICreateOrderController
    {
        ValueTask<int> CreateOrder(CreateOrderDTO order);
    }
}