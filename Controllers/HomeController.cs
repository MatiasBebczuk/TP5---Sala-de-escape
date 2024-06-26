using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TP5___Sala_de_escape.Models;

namespace TP5___Sala_de_escape.Controllers
{
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

        public IActionResult Tutorial()
        {
            return View();
        }

        public IActionResult Comenzar()
        {
            return View();
        }

        public IActionResult Habitacion(int sala, string clave)
        {
            bool salaCorrecta = true;
            bool claveCorrecta = true;

            if (salaCorrecta == false)
            {

                return RedirectToAction("Comenzar"); 
            }

            if (claveCorrecta == false)
            {

                ViewBag.Error = "La respuesta escrita fue incorrecta."; 
                return View(); 
            }

            return View("Victoria");
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
}
