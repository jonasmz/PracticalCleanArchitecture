using NortWind.Sales.BusinessObjects.POCOEntities;
using NortWind.Sales.BusinessObjects.ValueObjects;

namespace NortWind.Sales.BusinessObjects.Agregates
{
    public class OrderAggregate : Order
    {
        private readonly List<OrderDetail> OrderDetailsField = new();

        public IReadOnlyCollection<OrderDetail> OrderDetails => OrderDetailsField;

        public void AddDetail(OrderDetail orderDetail){
            var ExistingOrderDetail = OrderDetailsField.FirstOrDefault(od => od.ProductId == orderDetail.ProductId);

            if(ExistingOrderDetail == default){
                OrderDetailsField.Add(orderDetail);
            }else{
                OrderDetailsField.Add(
                    ExistingOrderDetail with{
                        Quantity = (short) (orderDetail.Quantity + ExistingOrderDetail.Quantity)
                    }
                );
                OrderDetailsField.Remove(ExistingOrderDetail);
            }
        }

        public void AddDetail(int productId, Decimal unitPrice, short quantity){
            AddDetail(new OrderDetail(productId, unitPrice, quantity));
        }
    }
}