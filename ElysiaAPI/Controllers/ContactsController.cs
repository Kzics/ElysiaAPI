using ElysiaAPI.Objects;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ElysiaAPI.Controllers;

public class ContactsController : ControllerBase
{
    private readonly ElysiaDbContext _dbContext;

    public ContactsController(ElysiaDbContext dbContext)
    {
        _dbContext = dbContext;
    }
    
    [HttpGet]
    public async Task<ActionResult<List<Contact>>> GetContacts()
    {
        var contacts = await _dbContext.Contacts.ToListAsync();

        if (contacts.Count == 0)
        {
            return NotFound();
        }

        return contacts;
    }
}