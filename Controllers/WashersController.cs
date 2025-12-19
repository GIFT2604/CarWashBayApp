using CarWashBayApp.Services;
using Microsoft.AspNetCore.Mvc;

public class WashersController : Controller
{
    private readonly CarWashService _service;

    public WashersController(CarWashService service)
    {
        _service = service;
    }

    public IActionResult Index()
    {
        return View(_service.Washers);
    }

    [HttpPost]
    public IActionResult Create(string name)
    {
        _service.AddWasher(name);
        return RedirectToAction("Index");
    }
}
