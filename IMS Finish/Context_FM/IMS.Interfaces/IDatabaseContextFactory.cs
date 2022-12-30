using IMS.Data.Interfaces;

namespace IMS.Interfaces
{
    public interface IDatabaseContextFactory
    {
        public InventoryDatabaseContext CreateDatabaseContext(Guid customerInstance);
    }
}
