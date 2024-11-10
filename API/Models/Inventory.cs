namespace API.Models
{
    public class Inventory
    {
        public int Id { get; set; }
        public int SupplierId { get; set; }

        // Navigation properties
        public Supplier Supplier { get; set; }
        public ICollection<InventoryProduct> InventoryProducts { get; set; }
    }
}
