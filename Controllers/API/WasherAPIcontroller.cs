using CarWashBayApp.Services;

using Microsoft.AspNetCore.Mvc;

namespace CarWashBay.Web.Controllers.Api;

[ApiController]
[Route("api/[controller]")]
public class WashersApiController : ControllerBase
{
    private readonly CarWashService _service;

    public WashersApiController(CarWashService service)
    {
        _service = service;
    }

    [HttpPost("add")]
    public IActionResult AddWasher(string name)
    {
        _service.AddWasher(name);
        return Ok(new { message = $"Washer '{name}' added successfully." });
    }

    [HttpGet("list")]
    public IActionResult GetWashers()
    {
        return Ok(_service.Washers);
    }
}
