namespace API.Models
{
    public class Quote
    {
        public int Id { get; set; }
        public int SupplierId { get; set; }
        public string Product { get; set; }
        public decimal Price { get; set; }
        public DateTime Date { get; set; }

        // Navigation property
        public Supplier Supplier { get; set; }
    }
}
