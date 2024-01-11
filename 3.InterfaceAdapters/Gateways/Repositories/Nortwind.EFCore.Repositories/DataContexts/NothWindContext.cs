using System.Reflection;
using Microsoft.EntityFrameworkCore;
using Nortwind.EFCore.Repositories.Entities;
using NortWind.Sales.BusinessObjects.POCOEntities;

namespace Nortwind.EFCore.Repositories.DataContexts
{
    internal class NothWindContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data source=../../../../4.FrameworksAndDrivers/NortWindDB.sqlite");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }

        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }

    }
}