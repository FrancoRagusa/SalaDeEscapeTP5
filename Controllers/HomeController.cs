using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using SalaDeEscapeTP5.Models;

namespace SalaDeEscapeTP5.Controllers;

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
        public IActionResult Tutotial()
    {
        return View();
    }
        public IActionResult Comenzar()
    {
        return View();
    }
        public IActionResult Habitacion()
    {
        return View();
    }
}
