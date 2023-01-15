namespace IMS.Models
{
    public class Inventory
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public int StockCount { get; set; }

        public decimal CostPrice { get; set; }

        public decimal SalePrice { get; set; }

        public DateTime Created { get; set; }

        public DateTime LastUpdated { get; set; }
    }
}
