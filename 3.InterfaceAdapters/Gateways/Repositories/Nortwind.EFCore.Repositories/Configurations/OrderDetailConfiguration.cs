using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Nortwind.EFCore.Repositories.Entities;

namespace Nortwind.EFCore.Repositories.Configurations
{
    public class OrderDetailConfiguration : IEntityTypeConfiguration<OrderDetail>
    {
        public void Configure(EntityTypeBuilder<OrderDetail> builder)
        {
            builder.HasKey(od => new {od.OrderId, od.ProductId});
            builder.Property(od => od.UnitPrice)
                .HasPrecision(8, 2);
        }
    }
}