using IMS.Models;
using Microsoft.EntityFrameworkCore;

namespace IMS.Data.Interfaces
{
    public interface InventoryDatabaseContext
    {
        public DbSet<Inventory> Inventory { get; set; }
    }
}
