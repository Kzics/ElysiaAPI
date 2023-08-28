using ElysiaAPI.Objects;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ElysiaAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class BizsController : ControllerBase
{
    private readonly ElysiaDbContext _dbContext;

    public BizsController(ElysiaDbContext dbContext)
    {
        _dbContext = dbContext;
    }


    [HttpGet("Biz")]
    public async Task<ActionResult<Bizs>> GetBiz(int id)
    {
        var biz = await _dbContext.Bizs.FindAsync(id);
        
        if (biz == null)
        {
            return NotFound();
        }

        biz.Contact ??= string.Empty;
        biz.Description ??= string.Empty;

        return biz;
    }
    
    [HttpGet("character-owner-biz")]
    public async Task<ActionResult<Bizs>> GetPlayerBiz(int characterId)
    {
        var biz = await _dbContext.Bizs.Where(bizs => bizs.OwnerId == characterId)
            .FirstOrDefaultAsync();

        if (biz == null)
        {
            return NotFound();
        }
        return biz;
    }

}