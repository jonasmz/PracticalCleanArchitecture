using System.Runtime.CompilerServices;
using NortWind.Sales.BusinessObjects.Agregates;
using NortWind.Sales.BusinessObjects.DTOs.CreateOrder;
using NortWind.Sales.BusinessObjects.Interfaces.Ports;
using NortWind.Sales.BusinessObjects.Interfaces.Repositories;

namespace NortWind.Sales.UseCases.CreateOrder
{
    public class CreateOrderInteractor : ICreateOrderInputPort
    {
        private readonly ICreateOrderOutputPort _outputPort;
        private readonly INorthWindSalesCommandsRepository _repository;

        public CreateOrderInteractor(
            ICreateOrderOutputPort outputPort, 
            INorthWindSalesCommandsRepository repository
            )
        {
            _outputPort = outputPort;
            _repository = repository;
        }
        public async ValueTask Handle(CreateOrderDTO orderDTO)
        {
            OrderAggregate order = new OrderAggregate{
                CustomerId = orderDTO.CustomerId,
                ShipAddress = orderDTO.ShipAddress,
                ShipCity = orderDTO.ShipCity,
                ShipCountry = orderDTO.ShipCountry,
                ShipPostalCode = orderDTO.ShipPostalCode
            };

            foreach(var item in orderDTO.OrderDetails){
                order.AddDetail(item.ProductId, item.UnitPrice, item.Qantity);
            }

            await _repository.CreateOrder(order);
            await _repository.SaveChanges();
            await _outputPort.Handle(order.Id);
        }
    }
}