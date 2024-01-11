using System.Reflection;
using Microsoft.EntityFrameworkCore;
using Nortwind.EFCore.Repositories.Entities;
using NortWind.Sales.BusinessObjects.POCOEntities;

namespace Nortwind.EFCore.Repositories.DataContexts
{
    public class NorthWindSalesContext : DbContext
    {
        public NorthWindSalesContext(DbContextOptions<NorthWindSalesContext> options) : base(options){

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }

        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }

    }
}