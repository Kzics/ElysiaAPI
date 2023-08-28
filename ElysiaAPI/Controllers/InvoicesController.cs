using ElysiaAPI.Objects;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ElysiaAPI.Controllers;


[ApiController]
[Route("[controller]")]
public class InvoicesController : ControllerBase
{
    
    private ElysiaDbContext _dbContext;
    
    public InvoicesController(ElysiaDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    [HttpGet("invoice")]
    public async Task<ActionResult<Invoice>> GetInvoice(int id)
    {
        var invoice = await _dbContext.Invoices.FindAsync(id);

        if (invoice == null)
        {
            return NotFound();
        }

        return invoice;
    }


    [HttpPost("player-invoices")]
    public async Task<ActionResult<List<Invoice>>> GetPlayerInvoices(int characterId)
    {
        var invoices = await _dbContext.Invoices
            .Where(i => i.CharacterId == characterId)
            .ToListAsync();

        if (invoices.Count == 0)
        {
            return NotFound();
        }

        return invoices;
    }


}