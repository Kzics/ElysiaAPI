using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ElysiaAPI.Controllers;


[ApiController]
[Route("[controller]")]
public class VehicleInfosController : ControllerBase
{
    private readonly ElysiaDbContext _dbContext;

    public VehicleInfosController(ElysiaDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    [HttpGet("VehicleInfo")]
    public async Task<ActionResult<VehicleInfo>> GetVehicleInfo(int vehicleId)
    {
        var vehicleInfo = await _dbContext.VehicleInfos.FindAsync(vehicleId);

        if (vehicleInfo == null)
        {
            return NotFound();
        }

        return vehicleInfo;
    }
    
    [HttpGet]
    public async Task<ActionResult<List<VehicleInfo>>> GetVehicleInfos()
    {
        var vehicleInfo = await _dbContext.VehicleInfos.ToListAsync();

        if (vehicleInfo.Count == 0)
        {
            return NotFound();
        }

        return vehicleInfo;
    }
}