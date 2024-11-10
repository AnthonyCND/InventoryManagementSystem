using API.Models;

namespace API.Interfaces
{
    public interface IInventoryService
    {
        Task<IEnumerable<Inventory>> GetInventoriesAsync();
        Task<Inventory> GetInventoryByIdAsync(int id);
        Task AddInventoryAsync(Inventory inventory);
        Task UpdateInventoryAsync(Inventory inventory);
        Task DeleteInventoryAsync(int id);
    }
}
