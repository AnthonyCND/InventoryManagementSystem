namespace API.Models
{
    public class InventoryProduct
    {
        public int InventoryId { get; set; }
        public Inventory Inventory { get; set; }

        public int ProductId { get; set; }
        public Product Product { get; set; }

        public int Quantity { get; set; }
        public DateTime LastUpdated { get; set; }
    }
}
