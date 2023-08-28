using Microsoft.EntityFrameworkCore;

namespace ElysiaAPI.Controllers;

public class VehicleInfo
{
    public int CharacterId { get; set; }
    public int VehicleId { get; set; }
    public long DateDriving { get; set; }
    public double Kilometer { get; set; }
    
}