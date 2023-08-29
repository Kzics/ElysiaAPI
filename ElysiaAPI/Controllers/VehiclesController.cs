using ElysiaAPI.Objects;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

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

    [HttpGet]
    public async Task<ActionResult<List<Vehicle>>> GetVehicles()
    {
        var vehicle = await _dbContext.Vehicles.ToListAsync();

        if (vehicle.Count == 0)
        {
            return NotFound();
        }

        return vehicle;

    }
    [HttpGet("vehicle-by-id")]
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