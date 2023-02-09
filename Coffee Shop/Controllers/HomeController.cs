using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Coffee_Shop.Models;

namespace Coffee_Shop.Controllers;

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

    public IActionResult Form()
    {
        return View();
    }

    public IActionResult Result(User u)
    {
        return View(u);
    }

    public IActionResult Privacy()
    {
        int Year = 2023;
        return View(Year);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}

