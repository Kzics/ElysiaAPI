namespace ElysiaAPI.Objects;

public class Vehicle
{
    public int Id { get; set; }

    public int ModelId { get; set; }

    public string Plate { get; set; }

    public string Permissions { get; set; }

    public bool IsStowed { get; set; }

    public string Inventory { get; set; }

    public string EngineInventory { get; set; }

    public string Color { get; set; }

    public float Smoothness { get; set; }

    public float X { get; set; }

    public float Y { get; set; }

    public float Z { get; set; }

    public float RotX { get; set; }

    public float RotY { get; set; }

    public float RotZ { get; set; }

    public int BizId { get; set; }

    public float Fuel { get; set; }

    public string Damages { get; set; }

    public string Serigraphie { get; set; }

    public string EurosoftData { get; set; }

    public string AccessoriesData { get; set; }

}