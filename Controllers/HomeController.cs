using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using EjemploMVC4C.Models;

namespace EjemploMVC4C.Controllers;

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

    public IActionResult GenerarSugerencia(SugeridorReceta datos)
    {
        ViewBag.Nombre        = datos.Nombre;
        ViewBag.Edad          = datos.CalcularEdad();
        ViewBag.Plato         = datos.DeterminarPlato();
        ViewBag.Tiempo        = datos.CalcularTiempo();
        ViewBag.Dificultad    = datos.DeterminarDificultad();
        ViewBag.Personas      = datos.CantidadPersonas;
        return View("Resultado");
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
}
