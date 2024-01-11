namespace NortWind.Sales.BusinessObjects.DTOs.CreateOrder
{
    public class CreateOrderDetailDTO
    {
        public int ProductId { get; set; }
        public decimal UnitPrice { get; set; }
        public short Qantity { get; set; }
        
    }
}