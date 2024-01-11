using NortWind.Sales.BusinessObjects.DTOs.CreateOrder;

namespace NortWind.Sales.BusinessObjects.Interfaces.Ports
{
    public interface ICreateOrderInputPort
    {
        ValueTask Handle(CreateOrderDTO orderDTO);
    }
}