using API.Models;

namespace API.Interfaces
{
    public interface IQuoteService
    {
        Task<IEnumerable<Quote>> GetQuotesAsync();
        Task<Quote> GetQuoteByIdAsync(int id);
        Task AddQuoteAsync(Quote quote);
        Task UpdateQuoteAsync(Quote quote);
        Task DeleteQuoteAsync(int id);
    }
}
