using IMS.Data.Implementations;
using IMS.Data.Interfaces;
using IMS.Interfaces;

namespace IMS.Services
{
    public class DatabaseContextFactory : IDatabaseContextFactory
    {
        private readonly IServiceProvider _serviceProvider;

        public DatabaseContextFactory(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public InventoryDatabaseContext CreateDatabaseContext(Guid customerInstance)
            => customerInstance.ToString().ToLower() switch
            {
                "b8f85ea1-092d-45fb-9ec4-6a87820917d1" => (InventoryDatabaseContext)_serviceProvider.GetService(typeof(MapleWarehouseContext)),
                "43d8ed23-41eb-462d-ac31-ed92ed114944" => (InventoryDatabaseContext)_serviceProvider.GetService(typeof(PorterInventorySolutionsContext)),
                "7fe948b8-d767-433e-aca2-319505f765da" => (InventoryDatabaseContext)_serviceProvider.GetService(typeof(WhetherlyStockContext)),
                _ => throw new NotImplementedException("Could not find appropriate database")
            };
    }
}
