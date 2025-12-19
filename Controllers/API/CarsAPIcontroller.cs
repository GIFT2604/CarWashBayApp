using CarWashBayApp.Models; // Ensure this is the only VehicleType import

using CarWashBayApp.Services;
using Microsoft.AspNetCore.Mvc;

namespace CarWashBay.Web.Controllers.Api;

[ApiController]
[Route("api/[controller]")]
public class CarsApiController : ControllerBase
{
    private readonly CarWashService _service;

    public CarsApiController(CarWashService service)
    {
        _service = service;
    }

    [HttpPost("register")]
    public IActionResult RegisterCar(string plate, VehicleType type) // Use VehicleType from CarWashBayApp.Models
    {
        var result = _service.RegisterCar(plate, type);
        return Ok(new { message = result });
    }
}
