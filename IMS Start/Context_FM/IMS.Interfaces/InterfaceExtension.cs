using IMS.Data.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace IMS.Interfaces
{
    public static class InterfaceExtension
    {
        public async static Task SaveChangesAsync(this InventoryDatabaseContext inventoryDatabaseContext)
        {
            await ((DbContext)inventoryDatabaseContext).SaveChangesAsync();
        }
    }
}
