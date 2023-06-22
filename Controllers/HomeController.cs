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
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
    public IActionResult InicializarJuego()
{
    return View();
}
 public IActionResult Comenzar()
{
    int estadoJuego = Escape.GetEstadoJuego();
    string Sala = "sala" + (estadoJuego+1);
    return View(Sala);
}

public IActionResult Index()
{
    return View();
}


[HttpPost] public IActionResult Habitacion(string clave, int sala)
{
    Escape.InicializarJuego();
    int estadoJuego = Escape.GetEstadoJuego();

    bool correcto = Escape.ResolverSala(sala, clave);
    {
        if (!correcto)
        {
            ViewBag.paso = "no";
        }
        else
        {
            ViewBag.paso="si";
        }
        } 
        if (Escape.GetEstadoJuego() == 5)
        {
        return View("salafinal");
        
        }
        return View("Habitacion " + Escape.GetEstadoJuego());
    }

    // ViewBag.Error = "Respuesta incorrecta.";
    // return View("Habitacion : " + estadoJuego);


public IActionResult Tutorial()
{
    return View("");
}

}

