using NortWind.Entities.Interfaces;
using NortWind.Sales.BusinessObjects.Agregates;

namespace NortWind.Sales.BusinessObjects.Interfaces.Repositories
{
    public interface INorthWindSalesCommandsRepository : IUnitOfWork
    {
        ValueTask CreateOrder(OrderAggregate order);
    }
}