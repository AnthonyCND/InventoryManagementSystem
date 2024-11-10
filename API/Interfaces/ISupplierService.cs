using API.Models;

namespace API.Interfaces
{
    public interface ISupplierService
    {
        Task<IEnumerable<Supplier>> GetSuppliersAsync();
        Task<Supplier> GetSupplierByIdAsync(int id);
        Task AddSupplierAsync(Supplier supplier);
        Task UpdateSupplierAsync(Supplier supplier);
        Task DeleteSupplierAsync(int id);
    }
}
