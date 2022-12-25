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
            x = x + 0.2,
            y = y,
            z = z
        };

        ViewBag.Message = cube;
        return View("Index");
    }

    public IActionResult xDecr(double x, double y, double z)
    {
        Cube cube = new Cube
        {
            x = x - 0.2,
            y = y,
            z = z
        };

        ViewBag.Message = cube;
        return View("Index");
    }

    public IActionResult yIncr(double x, double y, double z)
    {
        Cube cube = new Cube
        {
            x = x,
            y = y + 0.2,
            z = z
        };

        ViewBag.Message = cube;
        return View("Index");
    }

    public IActionResult yDecr(double x, double y, double z)
    {
        Cube cube = new Cube
        {
            x = x,
            y = y - 0.2,
            z = z
        };

        ViewBag.Message = cube;
        return View("Index");
    }

    public IActionResult zIncr(double x, double y, double z)
    {
        Cube cube = new Cube
        {
            x = x,
            y = y,
            z = z + 0.2
        };

        ViewBag.Message = cube;
        return View("Index");
    }

    public IActionResult zDecr(double x, double y, double z)
    {
        Cube cube = new Cube
        {
            x = x,
            y = y,
            z = z - 0.2
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

