using NortWind.Sales.BusinessObjects.DTOs.CreateOrder;
using NortWind.Sales.BusinessObjects.Interfaces.Controllers;
using NortWind.Sales.BusinessObjects.Interfaces.Ports;
using NortWind.Sales.BusinessObjects.Interfaces.Presenters;

namespace NortWind.Sales.Controllers
{
    public class CreateOrderController : ICreateOrderController
    {
        private readonly ICreateOrderInputPort _inputPort;
        private readonly ICreateOrderPresenter _presenter;

        public CreateOrderController(ICreateOrderInputPort inputPort, ICreateOrderPresenter presenter)
        {
            _inputPort = inputPort;
            _presenter = presenter;
        }

        public async ValueTask<int> CreateOrder(CreateOrderDTO order)
        {
            await _inputPort.Handle(order);
            return _presenter.OrderId;
        }
    }
}