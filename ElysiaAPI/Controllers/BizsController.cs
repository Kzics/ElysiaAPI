using ElysiaAPI.Objects;
using Microsoft.AspNetCore.Authorization;
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


    [HttpGet]
    public async Task<ActionResult<List<Bizs>>> GetBizs()
    {
        var bizs = await _dbContext.Bizs.ToListAsync();
        
        if (bizs.Count == 0)
        {
            return NotFound();
        }

        return bizs;
    }
    
    [HttpGet("biz-by-id")]
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