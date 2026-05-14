using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TP02_Recetify_GrunblattyDiPaolo.Models;

namespace TP02_Recetify_GrunblattyDiPaolo.Controllers;

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

    [HttpPost]
    public IActionResult GenerarSugerencia(SugeridorReceta Sugerencia)
    {
        ViewBag.Plato = Sugerencia.DeterminarPlato();
        ViewBag.Dificultad = Sugerencia.DeterminarDificultad();
        ViewBag.Edad = Sugerencia.CalcularEdad();
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
