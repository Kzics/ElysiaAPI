using ElysiaAPI.Objects;
using Microsoft.AspNetCore.Mvc;

namespace ElysiaAPI.Controllers;


[ApiController]
[Route("[controller]")]
public class VehiclesController : ControllerBase
{
    private readonly ElysiaDbContext _dbContext;

    public VehiclesController(ElysiaDbContext dbContext)
    {
        _dbContext = dbContext;
    }


    [HttpGet("Vehicles")]
    public async Task<ActionResult<Vehicle>> GetVehicles(int id)
    {
        var vehicle = await _dbContext.Vehicles.FindAsync(id);

        if (vehicle == null)
        {
            return NotFound();
        }
        
        return vehicle;
    }



}