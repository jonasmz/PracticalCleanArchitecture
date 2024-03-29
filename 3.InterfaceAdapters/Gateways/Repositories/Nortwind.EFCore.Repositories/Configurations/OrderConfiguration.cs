using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NortWind.Sales.BusinessObjects.POCOEntities;

namespace Nortwind.EFCore.Repositories.Configurations
{
    public class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.Property(o => o.CustomerId)
                .IsRequired()
                .HasMaxLength(5)
                .IsFixedLength();
            builder.Property(o => o.ShipAddress)
                .IsRequired()
                .HasMaxLength(60);
            builder.Property(o => o.ShipCity)
                .HasMaxLength(60);
            builder.Property(o => o.ShipCountry)
                .HasMaxLength(15);
            builder.Property(o => o.ShipPostalCode)
                .HasMaxLength(10);
        }
    }
}