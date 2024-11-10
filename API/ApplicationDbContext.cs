using API.Models;
using Microsoft.EntityFrameworkCore;

namespace API
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
: base(options)
        {
        }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<Quote> Quotes { get; set; }
        public DbSet<Inventory> Inventories { get; set; }
        public DbSet<InventoryProduct> InventoryProducts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Supplier-Inventory one-to-one relationship
            modelBuilder.Entity<Supplier>()
            .HasOne(s => s.Inventory)
            .WithOne(i => i.Supplier)
            .HasForeignKey<Inventory>(i => i.SupplierId);

            // Supplier-Quote one-to-many relationship
            modelBuilder.Entity<Quote>()
            .HasOne(q => q.Supplier)
            .WithMany(s => s.Quotes)
            .HasForeignKey(q => q.SupplierId);

            // Inventory-Product many-to-many relationship
            modelBuilder.Entity<InventoryProduct>()
            .HasKey(ip => new { ip.InventoryId, ip.ProductName });

            modelBuilder.Entity<InventoryProduct>()
            .HasOne(ip => ip.Inventory)
            .WithMany(i => i.InventoryProducts)
            .HasForeignKey(ip => ip.InventoryId);
        }

    }    
}
