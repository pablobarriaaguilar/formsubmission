using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using formsubmission.Models;

namespace formsubmission.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }

    public IActionResult Create(Heroe _heroe){

        if(ModelState.IsValid)
        {
            return View("Result", _heroe);
        }else
        {
            return View("Index");
        }
    }
}
