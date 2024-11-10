using API.Interfaces;
using API.Models;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class QuotesController : ControllerBase
    {
        private readonly IQuoteService _quoteService;

        public QuotesController(IQuoteService quoteService)
        {
            _quoteService = quoteService;
        }

        [HttpGet]
        public async Task<IActionResult> GetQuotes()
        {
            var quotes = await _quoteService.GetQuotesAsync();
            return Ok(quotes);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetQuote(int id)
        {
            var quote = await _quoteService.GetQuoteByIdAsync(id);
            if (quote == null)
            {
                return NotFound();
            }
            return Ok(quote);
        }

        [HttpPost]
        public async Task<IActionResult> AddQuote(Quote quote)
        {
            await _quoteService.AddQuoteAsync(quote);
            return CreatedAtAction(nameof(GetQuote), new { id = quote.Id }, quote);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateQuote(int id, Quote quote)
        {
            if (id != quote.Id)
            {
                return BadRequest();
            }
            await _quoteService.UpdateQuoteAsync(quote);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteQuote(int id)
        {
            await _quoteService.DeleteQuoteAsync(id);
            return NoContent();
        }
    }
}
