using IMS.Models;

namespace IMS.Interfaces
{
    public interface IInventoryService
    {
        Task<Inventory> AddInventoryAsync(Inventory inventory);

        Task UpdateInventoryAsync(Inventory inventory);

        Task<Inventory> GetInventoryByIdAsync(int id);

        Task<int> UpdateStockCountAsync(int id, int deltaChange);
    }
}
