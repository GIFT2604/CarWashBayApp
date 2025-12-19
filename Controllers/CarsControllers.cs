using CarWashBayApp.Models;
using CarWashBayApp.Services;
using Microsoft.AspNetCore.Mvc;

public class CarsController : Controller
{
    private readonly CarWashService _service;

    public CarsController(CarWashService service)
    {
        _service = service;
    }

    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Create(string plate, VehicleType type)
    {
        ViewBag.Message = _service.RegisterCar(plate, type);
        return View();
    }
}
