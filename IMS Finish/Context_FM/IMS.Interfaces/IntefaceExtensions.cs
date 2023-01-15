using Microsoft.EntityFrameworkCore;
using IMS.Data.Interfaces;

namespace IMS.Interfaces
{
    public static class IntefaceExtensions
    {
        public async static Task SaveChangesAsync(this InventoryDatabaseContext inventoryDatabaseContext)
        { 
            await ((DbContext)inventoryDatabaseContext).SaveChangesAsync();
        }
    }
}
