using CarWashBayApp.Models;

namespace CarWashBayApp.Models;


public enum VehicleType
{
    Truck,
    MiniVan,
    Saloon,
    Motorbike
}

public class Car
{
    public int Id { get; set; }
    public required string Plate { get; set; }

    public VehicleType Type { get; set; }

    public int WasherId { get; set; }
    public required Washer Washer { get; set; }
}

