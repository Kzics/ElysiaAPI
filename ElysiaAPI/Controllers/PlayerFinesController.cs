using ElysiaAPI.Objects;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ElysiaAPI.Controllers;

[ApiController]
[Route("[controller]")]

public class PlayerFinesController : ControllerBase
{

    private ElysiaDbContext _dbContext;
    
    public PlayerFinesController(ElysiaDbContext dbContext)
    {
        _dbContext = dbContext;
    }
    
    [HttpGet("fine")]
    public async Task<ActionResult<PlayerFine>> GetPlayerFine(int id)
    {
        var invoice = await _dbContext.PlayerFines.FindAsync(id);

        if (invoice == null)
        {
            return NotFound();
        }

        return invoice;
    }


    [HttpPost("character-playerFines")]
    public async Task<ActionResult<List<PlayerFine>>> GetPlayerFines(int characterId)
    {
        var fines = await _dbContext.PlayerFines.Where(fine => fine.ReceiverId == characterId)
            .ToListAsync();

        if (fines.Count == 0)
        {
            return NotFound();
        }

        return fines;
    }
    
    
}