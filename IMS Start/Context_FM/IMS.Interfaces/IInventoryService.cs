using IMS.Models;

namespace IMS.Interfaces
{
    public interface IInventoryService
    {
        Task<Inventory> AddInventoryAsync(Inventory inventory, Guid customer);

        Task UpdateInventoryAsync(Inventory inventory, Guid customer);

        Task<Inventory> GetInventoryByIdAsync(int id, Guid customer);

        Task<int> UpdateStockCountAsync(int id, int deltaChange, Guid customer);
    }
}
