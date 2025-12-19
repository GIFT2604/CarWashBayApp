using CarWashBayApp.Data;
using CarWashBayApp.Models;

namespace CarWashBayApp.Services;

public class CarWashService
{
    private readonly AppDbContext _db;

    public CarWashService(AppDbContext db)
    {
        _db = db;
    }

    public List<Washer> Washers => _db.Washers.ToList();

    public void AddWasher(string name)
    {
        _db.Washers.Add(new Washer { Name = name });
        _db.SaveChanges();
    }

    public string RegisterCar(string plate, VehicleType type)
    {
        var washer = _db.Washers.FirstOrDefault();

        if (washer == null)
            return "No washers available.";

        _db.Cars.Add(new Car
        {
            Plate = plate,
            Type = type,
            WasherId = washer.Id,
            Washer = washer 
        });

        _db.SaveChanges();

        return $"Car assigned to washer {washer.Name}";
    }
}