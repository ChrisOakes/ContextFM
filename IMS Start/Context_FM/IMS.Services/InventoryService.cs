using IMS.Data;
using IMS.Interfaces;
using IMS.Models;
using Microsoft.EntityFrameworkCore;

namespace IMS.Services
{
    public class InventoryService : IInventoryService
    {
        private readonly IDatabaseContextFactory _databaseContextFactory;

        public InventoryService(IDatabaseContextFactory databaseContextFactory)
        {
            _databaseContextFactory = databaseContextFactory;
        }

        public async Task<Inventory> AddInventoryAsync(Inventory inventory, Guid customer)
        {
            try
            {
                var context = _databaseContextFactory.CreateDatabaseContext(customer);

                inventory.Created = DateTime.Now;
                inventory.LastUpdated = DateTime.Now;

                context.Inventory.Add(inventory);

                await context.SaveChangesAsync();

                return inventory;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public async Task<Inventory> GetInventoryByIdAsync(int id, Guid customer)
        {
            try
            {
                var context = _databaseContextFactory.CreateDatabaseContext(customer);

                var inventory = await context.Inventory.FirstOrDefaultAsync(x => x.Id == id);

                return inventory;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task UpdateInventoryAsync(Inventory inventory, Guid customer)
        {
            try
            {
                var context = _databaseContextFactory.CreateDatabaseContext(customer);

                inventory.LastUpdated = DateTime.Now;

                context.Inventory.Attach(inventory).State = EntityState.Modified;

                await context.SaveChangesAsync();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<int> UpdateStockCountAsync(int id, int deltaChange, Guid customer)
        {
            try
            {
                var inventory = await GetInventoryByIdAsync(id, customer);

                if (inventory is null)
                {
                    return -999;
                }

                inventory.StockCount += deltaChange;

                await UpdateInventoryAsync(inventory, customer);

                return inventory.StockCount;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
