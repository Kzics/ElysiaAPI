using ElysiaAPI.Objects;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ElysiaAPI.Controllers;

public class CharactersController : ControllerBase
{
    private readonly ElysiaDbContext _dbContext;

    public CharactersController(ElysiaDbContext dbContext)
    {
        _dbContext = dbContext;
    }
    
    [HttpGet]
    public async Task<ActionResult<List<Character>>> GetCharacters()
    {
        var character = await _dbContext.Characters.ToListAsync();

        if (character.Count == 0)
        {
            return NotFound();
        }

        return character;
    }
    
    
}