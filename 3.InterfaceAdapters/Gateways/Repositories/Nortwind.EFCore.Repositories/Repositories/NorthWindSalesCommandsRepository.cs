using Nortwind.EFCore.Repositories.DataContexts;
using Nortwind.EFCore.Repositories.Entities;
using NortWind.Sales.BusinessObjects.Agregates;
using NortWind.Sales.BusinessObjects.Interfaces.Repositories;
namespace Nortwind.EFCore.Repositories.Repositories
{
    public class NorthWindSalesCommandsRepository : INorthWindSalesCommandsRepository
    {
        private readonly NorthWindSalesContext _context;

        public NorthWindSalesCommandsRepository(NorthWindSalesContext context)
        {
            _context = context;
        }

        public async ValueTask CreateOrder(OrderAggregate order)
        {
            await _context.AddAsync(order);
            foreach(var item in order.OrderDetails){
                await _context.AddAsync(new OrderDetail{
                    Order = order,
                    ProductId = item.ProductId,
                    Quantity = item.Quantity,
                    UnitPrice = item.UnitPrice
                });
            }
        }

        public async ValueTask SaveChanges()
        {
            await _context.SaveChangesAsync();
        }
    }
}