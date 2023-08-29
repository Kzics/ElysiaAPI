using ElysiaAPI.Objects;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ElysiaAPI.Controllers;

public class SMSController : ControllerBase
{
    private readonly ElysiaDbContext _dbContext;

    public SMSController(ElysiaDbContext dbContext)
    {
        _dbContext = dbContext;
    }



    [HttpGet]
    public async Task<ActionResult<List<SMS>>> GetSMS()
    {
        var sms = await _dbContext.SMS.ToListAsync();

        if (sms.Count == 0)
        {
            return NotFound();
        }

        return sms;
    }

}