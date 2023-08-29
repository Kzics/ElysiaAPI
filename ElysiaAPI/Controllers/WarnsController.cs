using ElysiaAPI.Objects;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ElysiaAPI.Controllers;

public class WarnsController : ControllerBase
{
    private readonly ElysiaDbContext _dbContext;

    public WarnsController(ElysiaDbContext dbContext)
    {
        _dbContext = dbContext;
    }


    [HttpGet()]
    public async Task<ActionResult<List<Warn>>> GetGlobalWarns()
    {
        var globalWarns = await _dbContext.Warns.ToListAsync();

        if (globalWarns.Count == 0)
        {
            return NotFound();
        }

        return globalWarns;
    }
    [HttpGet("account-warns")]
    public async Task<ActionResult<List<Warn>>> GetAccountWarns(int accountId)
    {
        var warns = await _dbContext.Warns.Where(warn => warn.AccountId == accountId)
            .ToListAsync();

        if (warns.Count == 0)
        {
            return NotFound();
        }

        return warns;
    }

}