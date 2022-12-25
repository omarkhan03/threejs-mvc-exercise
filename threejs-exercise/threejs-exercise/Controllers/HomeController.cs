using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using threejs_exercise.Models;

namespace threejs_exercise.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        Cube cube = new Cube
        {
            x = 1,
            y = 1,
            z = 1
        };

        ViewBag.Message = cube;
        return View();
    }


    public IActionResult xIncr(double x, double y, double z)
    {
        Cube cube = new Cube
        {
            x = x+0.1,
            y = y,
            z = 1
        };

        ViewBag.Message = cube;
        return View("Index");
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}

