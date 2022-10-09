using IMS.Data;
using IMS.Interfaces;
using IMS.Models;
using Microsoft.EntityFrameworkCore;

namespace IMS.Services
{
    public class InventoryService : IInventoryService
    {
        private readonly InventoryManagementContext _context;

        public InventoryService(InventoryManagementContext context)
        {
            _context = context;
        }

        public async Task<Inventory> AddInventoryAsync(Inventory inventory)
        {
            try
            {
                inventory.Created = DateTime.Now;
                inventory.LastUpdated = DateTime.Now;

                _context.Inventory.Add(inventory);

                await _context.SaveChangesAsync();

                return inventory;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public async Task<Inventory> GetInventoryByIdAsync(int id)
        {
            try
            {
                var inventory = await _context.Inventory.FirstOrDefaultAsync(x => x.Id == id);

                return inventory;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task UpdateInventoryAsync(Inventory inventory)
        {
            try
            {
                inventory.LastUpdated = DateTime.Now;

                _context.Inventory.Attach(inventory).State = EntityState.Modified;

                await _context.SaveChangesAsync();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<int> UpdateStockCountAsync(int id, int deltaChange)
        {
            try
            {
                var inventory = await GetInventoryByIdAsync(id);

                if (inventory is null)
                {
                    return -999;
                }

                inventory.StockCount += deltaChange;

                await UpdateInventoryAsync(inventory);

                return inventory.StockCount;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
