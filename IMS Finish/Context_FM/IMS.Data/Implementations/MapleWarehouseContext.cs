using IMS.Data.Interfaces;
using IMS.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS.Data.Implementations
{
    public class MapleWarehouseContext : DbContext, InventoryDatabaseContext
    {
        public MapleWarehouseContext(DbContextOptions<MapleWarehouseContext> options)
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
