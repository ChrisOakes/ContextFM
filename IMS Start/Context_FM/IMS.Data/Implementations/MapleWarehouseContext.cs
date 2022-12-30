using IMS.Data.Interfaces;
using IMS.Models;
using Microsoft.EntityFrameworkCore;

namespace IMS.Data.Implementations
{
    public class MapleWarehouseContext : DbContext, InventoryDatabaseContext
    {
        public MapleWarehouseContext(DbContextOptions<MapleWarehouseContext> options)
            : base (options) { }

        public DbSet<Inventory> Inventory { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Inventory>()
                .HasKey(x => x.Id);
        }
    }
}
