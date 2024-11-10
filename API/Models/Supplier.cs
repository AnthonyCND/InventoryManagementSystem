namespace API.Models
{
    public class Supplier
    {
        public int Id { get; set; }
        public string Name { get; set; }

        // Navigation properties
        public Inventory Inventory { get; set; }
        public ICollection<Quote> Quotes { get; set; }
    }
}
