using ElysiaAPI.Objects;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ElysiaAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class AccountsController : ControllerBase
{

    private ElysiaDbContext _dbContext;
    
    public AccountsController(ElysiaDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    [HttpGet]
    public async Task<ActionResult<List<Account>>> GetAccounts()
    {
        var account = await _dbContext.Accounts.ToListAsync();

        if (account.Count == 0)
        {
            return NotFound();
        }

        return account;
    }

    [HttpGet("account")]
    public async Task<ActionResult<Account>> GetAccount(string steamId)
    {
        var account = await _dbContext.Accounts.Where(acc => acc.SteamId == steamId)
            .FirstOrDefaultAsync();

        if (account == null)
        {
            return NotFound();
        }

        return account;
    }
    
    [HttpPost("accounts")]
    public async Task<ActionResult<List<Account>>> GetAccountsByIds([FromBody] List<int> steamIds)
    {
        if (steamIds.Count == 0)
        {
            return BadRequest("Invalid request");
        }

        var accounts = await _dbContext.Accounts.Where(a => steamIds.Contains(a.Id)).ToListAsync();

        if (accounts.Count == 0)
        {
            return BadRequest("NO its false");
        }

        return accounts;
    }
}