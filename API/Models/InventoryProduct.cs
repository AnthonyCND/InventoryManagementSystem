namespace API.Models
{
    public class InventoryProduct
    {
        public int InventoryId { get; set; }
        public Inventory Inventory { get; set; }

        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public decimal PricePerItem { get; set; }
        public DateTime LastUpdated { get; set; }
    }
}
