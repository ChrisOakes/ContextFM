using IMS.Data.Interfaces;
using IMS.Models;
using Microsoft.EntityFrameworkCore;

namespace IMS.Data.Implementations
{
    public class WhetherlyStockContext : DbContext, InventoryDatabaseContext
    {
        public WhetherlyStockContext(DbContextOptions<WhetherlyStockContext> options)
        : base(options)
        {
        }

        public virtual DbSet<Inventory> Inventory { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Inventory>()
                .HasKey(x => x.Id);
        }
    }
}
