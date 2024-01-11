using NortWind.Sales.BusinessObjects.Interfaces.Ports;

namespace NortWind.Sales.BusinessObjects.Interfaces.Presenters
{
    public interface ICreateOrderPresenter : ICreateOrderOutputPort
    {
        int OrderId {get; }
    }
}