using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TP10_JQuery.Models;

namespace TP10_JQuery.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        ViewBag.Series = BD.ObtenerSeries();
        return View();
    }
    [HttpPost]
    public List<Actores> getActores(int IdSerie){
        return BD.ObtenerActores(IdSerie);
    }


    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
